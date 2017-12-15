using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OQTPH.Models;
using OQTPH.Utils;

namespace OQTPH
{
    public static class ServicosDefault
    {
        private static int itensPorPagina = 6;

        public static List<Evento> CarregarEventos()
        {
            int numeroDeEventos = 0;
            int numeroDaPagina = 0;

            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Count(id_evento) FROM Evento", conn))
                {
                    numeroDeEventos = (int)cmd.ExecuteScalar();
                }

                int numeroDePaginas = (int)Math.Ceiling((double)numeroDeEventos / (double)itensPorPagina);

                if (numeroDePaginas == 0)
                {
                    numeroDaPagina = 1;
                }
                else if (numeroDePaginas < numeroDaPagina)
                {
                    numeroDaPagina = numeroDePaginas;
                }

                // verifica se há itens para se mostrar, caso não haja deve mostrar em um label q não tem ou uma imagem
                if (numeroDeEventos > 0)
                {
                    List<Evento> lista = new List<Evento>();
                    //faz busca por nome e id do evento na tabela evento por eventos q ainda tenham ingresso
                    using (SqlCommand cmd = new SqlCommand("SELECT Nome_evento, id_evento FROM Evento where nro_ingressos > 0 order by nome_evento offset @nItens * (@page - 1) rows fetch next @nItens rows only", conn))
                    {
                        //substitui os parametros com arroba na query pelo numero da pagina e pelo numero de itens por pagina
                        cmd.Parameters.AddWithValue("@page", numeroDaPagina);
                        cmd.Parameters.AddWithValue("@nItens", itensPorPagina);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Tenta obter o registro
                            while (reader.Read() == true)
                            {

                                string nome = reader.GetString(0);
                                int id = reader.GetInt32(1);

                                Evento evento = new Evento() { Id = id, Nome = nome };
                                lista.Add(evento);
                            }
                        }
                    }
                    return lista;
                }
                else
                {
                    throw new DadoNaoEncontradoException("Não há eventos!");
                }
            }
        }

        public static List<Evento> CarregarEventos(string categoria)
        {
            int numeroDeEventos = 0;
            int numeroDaPagina = 0;

            using (SqlConnection conn = Sql.OpenConnection())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Count(id_evento) FROM Evento where catg = @cat", conn))
                {
                    cmd.Parameters.AddWithValue("@cat", categoria);

                    numeroDeEventos = (int)cmd.ExecuteScalar();
                }

                int numeroDePaginas = (int)Math.Ceiling((double)numeroDeEventos / (double)itensPorPagina);

                if (numeroDePaginas < numeroDaPagina)
                {
                    numeroDaPagina = numeroDePaginas;
                }

                // verifica se há itens para se mostrar, caso não haja deve mostrar em um label q não tem ou uma imagem
                if (numeroDeEventos > 0 && numeroDePaginas > 0)
                {
                    List<Evento> lista = new List<Evento>();
                    //faz busca por nome e id do evento na tabela evento por eventos q ainda tenham ingresso
                    using (SqlCommand cmd = new SqlCommand("SELECT Nome_evento, id_evento FROM Evento where nro_ingressos > 0 and catg = @cat order by nome_evento offset @nItens * (@page - 1) rows fetch next @nItens rows only", conn))
                    {
                        //substitui os parametros com arroba na query pelo numero da pagina e pelo numero de itens por pagina
                        cmd.Parameters.AddWithValue("@cat", categoria);
                        cmd.Parameters.AddWithValue("@page", numeroDaPagina);
                        cmd.Parameters.AddWithValue("@nItens", itensPorPagina);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Tenta obter o registro
                            while (reader.Read() == true)
                            {
                                string nomeEv = reader.GetString(0);
                                int idEv = reader.GetInt32(1);

                                Evento evento = new Evento() { Id = idEv, Nome = nomeEv };
                                lista.Add(evento);
                            }
                        }
                    }

                    return lista;
                }
                else
                {
                    throw new DadoNaoEncontradoException("Não ha eventos!");
                }

            }

        }

    }
}
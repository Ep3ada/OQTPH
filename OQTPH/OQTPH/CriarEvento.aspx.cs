using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OQTPH.Models;

namespace OQTPH
{
    public partial class CriarEvento : System.Web.UI.Page
    {
        private Usuario _usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(_usuario != null)
            {
                

                Page.Title = "Atualizar Evento - OQTPH";

                // talvez de    va estar em evento ou criar um evento pra isso
                //_ehMeu = true;

                placeholderEvento.Visible = true;
                btnCriar.Visible = false;
                btnAtualiza.Visible = true;

                if (IsPostBack == false)
                {

                }

            }
        }
    }
}
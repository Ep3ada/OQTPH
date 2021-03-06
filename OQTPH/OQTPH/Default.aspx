﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OQTPH.Default" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>O que tem pra hoje?</title>

    <!-- Bootstrap -->
    <link href="/assets/css/style.css" rel="stylesheet" runat="server" />
    <link rel="icon" type="image/x-icon" href="/assets/images/logoAba.ico" />

</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <div class="container">

                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav">
                    </ul>
                    <ul class="nav navbar-nav">
                        <li class="active"></li>
                        <a href="Default.aspx">
                            <img src="/assets/images/logoSite.png" width="62" height="62" alt="" /></a>
                    </ul>

                    <ul class="nav navbar-nav navbar-right hidden-sm">

                        <div class="thumbnail">

                            <asp:PlaceHolder ID="PHin" runat="server">
                                <a href="Login.aspx">Entrar</a>&emsp;
                                <a href="Dados.aspx">Registrar</a>
                            </asp:PlaceHolder>
                            <asp:PlaceHolder ID="PHout" runat="server" Visible="False">
                                <a href="Perfil.aspx">Perfil</a>&emsp;
                                <a href="CriarEvento.aspx">Criar Evento</a>&emsp;                                
                                <asp:LinkButton ID="aOUT" OnClick="aOUT_Click" runat="server" meta:resourcekey="aOUTResource1">Sair</asp:LinkButton>

                            </asp:PlaceHolder>

                        </div>
                    </ul>

                </div>
            </div>
        </nav>
        <div class="container">
            <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <div class="carousel-inner">
                        <div class="item active">
                            <img class="img-responsive" src="/assets/images/bannerSite.jpg" alt="thumb" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <h2 class="text-center">EVENTOS</h2>
        <div class="container">

            <hr />
            <asp:PlaceHolder runat="server" ID="phEv">
                <div>
                    <div>
                        <label for="drop">Filtro:</label>
                        <div>
                            <asp:DropDownList ID="drop" runat="server" OnSelectedIndexChanged="drop_SelectedIndexChanged" EnableViewState="true" AutoPostBack="true" meta:resourcekey="dropResource1">
                                <asp:ListItem Text="Todas" Value="Todas" Selected="True" meta:resourcekey="ListItemResource1" />
                                <asp:ListItem Text="Ciência/Tecnologia" Value="Ciência/Tecnologia" meta:resourcekey="ListItemResource2" />
                                <asp:ListItem Text="Show" Value="Show" meta:resourcekey="ListItemResource3" />
                                <asp:ListItem Text="Infantil" Value="Infantil" meta:resourcekey="ListItemResource4" />
                                <asp:ListItem Text="Festa" Value="Festa" meta:resourcekey="ListItemResource5" />
                                <asp:ListItem Text="Teatro" Value="Teatro" meta:resourcekey="ListItemResource6" />
                                <asp:ListItem Text="Concerto" Value="Concerto" meta:resourcekey="ListItemResource7" />
                                <asp:ListItem Text="Stand-up" Value="Stand-up" meta:resourcekey="ListItemResource8" />
                                <asp:ListItem Text="Moda/Beleza" Value="Moda/Beleza" meta:resourcekey="ListItemResource9" />
                                <asp:ListItem Text="Artes" Value="Artes" meta:resourcekey="ListItemResource10" />
                                <asp:ListItem Text="Business" Value="Business" meta:resourcekey="ListItemResource11" />
                                <asp:ListItem Text="Dança" Value="Dança" meta:resourcekey="ListItemResource12" />
                                <asp:ListItem Text="Outras" Value="Outras" meta:resourcekey="ListItemResource13" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <br />
                    <div class="row text-center">
                        <div>
                            <div runat="server" id="divEven">
                                <%for (int i = 0; i < lista.Count; i++)
                                    {%>

                                <div class="col-sm-4 col-md-4 col-lg-4 col-xs-6">
                                    <div class="thumbnail">
                                        <img src="Imagehandler.ashx?idimgev=<%=lista[i].eventoID %>" alt="<%=lista[i].eventoNome %>" width="332" height="232" />
                                        <div class="caption">
                                            <h3><%=lista[i].eventoNome %></h3>
                                            <p><a href="Evento.aspx?evento=<%=lista[i].eventoID %>" class="btn btn-primary" role="button"><span aria-hidden="true"></span>Comprar</a></p>
                                        </div>
                                    </div>
                                </div>
                                <%} %>
                            </div>

                            <div runat="server" id="divPag">
                                <nav class="text-center">
                                    <ul class="pagination">
                                        <li><a runat="server" id="Aant" href="#" aria-label="Previous"><span aria-hidden="true">&laquo;</span> </a></li>
                                        <li class="active">
                                            <a href="#">
                                                <asp:Label ID="lbCur" runat="server" meta:resourcekey="lbCurResource1" /></a></li>
                                        <li><a runat="server" id="Aprox" href="#" aria-label="Next"><span aria-hidden="true">&raquo;</span> </a></li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:PlaceHolder>
            <asp:Label ID="lblMsg" runat="server" Visible="False" meta:resourcekey="lblMsgResource1" />

            <hr />
        </div>
        </div>

        <div class="container well">
            <div class="row">
                <div class="col-xs-6 col-sm-6 col-md-6 col-lg-5">
                    <address>
                        <strong>O que tem pra hoje?, Inc.</strong><br />
                        Digital School<br />
                        R. Estela, 268, SP, 04011-001<br />
                    </address>
                    <address>
                        <strong>Contato</strong><br />
                        <a href="mailto:#">ep3ada@gmail.com</a>
                    </address>
                </div>
            </div>
        </div>

        <footer class="text-center">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <p>Copyright © O que tem pra hoje?. All rights reserved.</p>
                    </div>
                </div>
            </div>
        </footer>
    </form>
</body>
</html>



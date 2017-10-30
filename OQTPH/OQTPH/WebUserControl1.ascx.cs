using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OQTPH.Utils;

namespace OQTPH
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.p.InnerText = "CUzao";
            }
            dd.DataSource = Categoria./*Enumeration.*/GetAll<Categoria._categorias>();
            dd.DataTextField = "Value";
            dd.DataValueField = "Key";
            dd.DataBind();

        }

        protected void dd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.p.InnerText = "CUzao";
            }
        }
    }
}
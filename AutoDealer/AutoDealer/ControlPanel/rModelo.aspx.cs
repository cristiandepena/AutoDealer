using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AutoDealer.ControlPanel
{
    public partial class rModelo : System.Web.UI.Page
    {
        public Marca marca;
        public Modelo modelo;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                marca = new Marca();
                ddlMarca.DataSource = marca.Listar("select IdMarca, Descripcion from Marcas");
                ddlMarca.DataTextField = "Descripcion";
                ddlMarca.DataValueField = "IdMarca";
                ddlMarca.DataBind();
                
            }
        }
    }
}
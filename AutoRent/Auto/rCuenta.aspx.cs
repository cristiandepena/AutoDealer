using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Auto
{
    public partial class rCuenta : System.Web.UI.Page
    {
        public Usuario usu = new Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbContrasena.Text.Equals(tbConfirmacion.Text))
            {
                usu.insertar();
            }
            else
            {
                Msg.Text = "Las contrasenas no coinciden...";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Web.Security;

namespace Auto.ControlPanel
{
    public partial class Login : System.Web.UI.Page
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
            string usuario = tbUsuario.Text;
            string contrasena = tbContrasena.Text;

            if (usu.Buscar(usuario, contrasena))
            {
                Session["LoginName"] = tbUsuario.Text;
                FormsAuthentication.RedirectFromLoginPage(usuario, Persist.Checked);

            }
        }
    }
}
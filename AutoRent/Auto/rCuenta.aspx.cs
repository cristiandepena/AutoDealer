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
        public Usuario usu;
        public Ciudad ciudad;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ciudad = new Ciudad();

                ddlCiudad.DataSource = ciudad.Listar("Select IdCiudad, Descripcion from Ciudades");
                ddlCiudad.DataTextField = "Descripcion";
                ddlCiudad.DataValueField = "IdCiudad";
                ddlCiudad.DataBind();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            usu = new Usuario();
            
            int idciudad = 0;
            int.TryParse(ddlCiudad.SelectedValue, out idciudad);

            usu.NombreUsuario = tbNombreUsuario.Text;
            usu.Contrasena = tbContrasena.Text;
            usu.Nombre = tbNombre.Text;
            usu.Apellido = tbApellido.Text;
            usu.FechaNacimiento = tbFechaNacimiento.Text;
            usu.Cedula = tbCedula.Text;
            usu.Telefono = tbTelefono.Text;
            usu.IdCiudad = idciudad;
            usu.Direccion = tbDireccion.Text;
            usu.Correo = tbCorreo.Text;

            if (usu.insertar())
            {
                Msg.Text = "Se ha registrado exitosamente!";
            }
        }
    }
}
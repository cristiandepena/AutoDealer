using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AutoRent
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public bool CargarImagen() 
        {
            bool msj = false;

            if (fuImagen.HasFile)
            {
                string fileExt =
                   System.IO.Path.GetExtension(fuImagen.FileName);

                if (fileExt == ".jpg" || fileExt == ".jpeg")
                {
                    msj = true;
                    try
                    {
                       
                    }
                    catch (Exception ex)
                    {
                        Msg.Text = "ERROR: " + ex.Message.ToString();
                    }
                }
                else
                {
                    msj = false;
                }
            }
            else
            {
                Msg.Text = "You have not specified a file.";
            }
            return msj;
        }

        public void limpiar()
        {
            tbId.Text = "";
            tbDescripcion.Text = "";
            tbPrecio.Text = "";
            ddlMarca.SelectedIndex = 0;
            ddlModelo.SelectedIndex = 0;
            ddlTipoTransmision.SelectedIndex = 0;
            ddlTipoVehiculo.SelectedIndex = 0;
            ddlTraccion.SelectedIndex = 0;
            ddlCombustible.SelectedIndex = 0;
            ddlCombustible.SelectedIndex = 0;
            ddlColorPrimario.SelectedIndex = 0;
            ddlColorSecundario.SelectedIndex = 0;
            ddlAnioFabricacion.SelectedIndex = 0;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            if (vehiculo.insertar())
            {
                Msg.Text = "El vehiculo se ha registrado exitosamente!";
            }
            else
            {
                Msg.Text = "Hubo un error al guardar el archivo, por favor intentelo de nuevo...";
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            int id = 0;
            int.TryParse(tbId.Text, out id);

            if (vehiculo.Buscar(id))
            {
                tbDescripcion.Text = vehiculo.Descripcion;
                tbPrecio.Text = vehiculo.Precio.ToString();
                ddlMarca.SelectedIndex = vehiculo.IdMarca;
                ddlModelo.SelectedIndex = vehiculo.IdModelo;
                ddlAnioFabricacion.SelectedIndex = vehiculo.AnoFabricacion;
                ddlColorPrimario.SelectedIndex = vehiculo.IdColor;
                ddlColorSecundario.SelectedIndex = vehiculo.IdColor;
                ddlCombustible.SelectedIndex = vehiculo.IdCombustible;
                ddlTipoTransmision.SelectedIndex = vehiculo.IdTransmision;
                ddlTipoVehiculo.SelectedIndex = vehiculo.IdTipoVehiculo;
                ddlTraccion.SelectedIndex = vehiculo.IdTipoTraccion;
            }
            else
            {
                tbId.Text = "";
                Msg.Text = "No se encontro ningun vehiculo con ese id...";

            }
        }

       
    }
}
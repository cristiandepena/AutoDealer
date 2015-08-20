using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AutoDealer.ControlPanel
{
    public partial class rCombustibles : System.Web.UI.Page
    {
        public Combustible combustible;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                deshabilitar();
            }

        }

        public void deshabilitar()
        {
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            tbId.Enabled = false;
            tbDescripcion.Enabled = false;
        }

        public void nuevo()
        {
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;
            btnRegistrar.Enabled = true;
            btnBuscar.Enabled = true;

            tbId.Enabled = true;
            tbDescripcion.Enabled = true;
        }

        public void limpiar()
        {
            tbId.Text = "";
            tbDescripcion.Text = "";
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            limpiar();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            combustible = new Combustible();
            combustible.Descripcion = tbDescripcion.Text;

            if (tbId.Text != string.Empty)
            {
                Msg.Text = "El campo de id debe estar vacio para realizar esta accion...";
            }
            else if (tbDescripcion.Text == string.Empty)
            {
                Msg.Text = "El campo de descripcion no puede estar vacio...";
            }
            else
            {
                if (combustible.insertar())
                {
                    Msg.Text = "El registro se ha guardado exitosamente!";
                }
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            combustible = new Combustible();

            combustible.Descripcion = tbDescripcion.Text;

            int id = 0;

            int.TryParse(tbId.Text, out id);

            if (tbDescripcion.Text == string.Empty)
            {
                Msg.Text = "Error, el campo de descripcion no puede estar vacio!";
            }
            else
            {
                if (combustible.modificar(id))
                {
                    Msg.Text = "El registro se ha modificado exitosamente!";
                }
            }
            deshabilitar();
            limpiar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            combustible = new Combustible();

            btnModificar.Enabled = true;
            int id = 0;
            int.TryParse(tbId.Text, out id);
            if (tbId.Text == string.Empty)
            {
                Msg.Text = "Error, debe digitar un id";
            }
            else {

                if (combustible.Buscar(id))
                {
                    id = combustible.IdCombustible;
                    tbDescripcion.Text = combustible.Descripcion;
                }
                else if(!combustible.Buscar(id))
                {
                    Msg.Text = "El id no existe...";
                    limpiar();
                }
            }

            btnEliminar.Enabled = true;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            combustible = new Combustible();

            int id = 0;
            int.TryParse(tbId.Text, out id);

            if (tbId.Text == string.Empty)
            {
                Msg.Text = "Error, debe digitar un id para eliminar el campo...";
            }
            else
            {
                if (combustible.eliminar(id))
                {
                    Msg.Text = "El registro se ha eliminado exitosamente!";
                }
            }
            limpiar();
        }




    }
}
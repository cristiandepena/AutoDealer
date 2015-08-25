using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AutoDealer.ControlPanel
{
    public partial class rMarca : System.Web.UI.Page
    {
        public Marca marca;
        public int IdMarca;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
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

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            marca = new Marca();
            marca.Descripcion = tbDescripcion.Text;

            if (tbDescripcion.Text == string.Empty)
            {
                Msg.Text = "Tiene que digitar un modelo...";
            }
            else if(Session["marca"] != null)
            {
                marca = (Marca)Session["marca"];
                marca.insertar();
                Msg.Text = "Exito!";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Msg.Text = "";

            marca = new Marca();

            int id = 0;
            int.TryParse(tbId.Text, out id);

            if (tbId.Text == string.Empty)
            {
                Msg.Text = "Error, debe digitar un id!";
            }
            else
            {
                if (marca.Buscar(id))
                {
                    id = marca.IdMarca;
                    tbDescripcion.Text = marca.Descripcion;
                }
                else if(!marca.Buscar(id))
                {
                    Msg.Text = "El id no existe...";
                    limpiar();
                }
            }

            btnEliminar.Enabled = true;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            marca = new Marca();

            int id = 0;

            int.TryParse(tbId.Text, out id);

            if (tbId.Text == string.Empty)
            {
                Msg.Text = "Error, debe digitar un id...";
            }
            else
            {
                if (marca.eliminar(id))
                {
                    Msg.Text = "El registro se ha eliminado exitosamente!";
                }
            }

            limpiar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            marca = new Marca();
            IdMarca = 0;

            if (Session["marca"] != null)
            {
                marca = (Marca)Session["marca"];
            }

            marca.AgregarModelo(tbModelo.Text);

            gvModelos.DataSource = marca.modelos;
            gvModelos.DataBind();

            Session["marca"] = marca;
            tbModelo.Text = "";
            Msg.Text = "Total: "+ gvModelos.Rows.Count.ToString();
        }
    }
}
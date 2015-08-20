using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace AutoDealer.ControlPanel
{
    public partial class rColor : System.Web.UI.Page
    {
        public Color color;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
  
            }
        }

        public void deshabilitar()
        {
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnRegistrar.Enabled = false;
            tbId.Enabled = false;
            tbColor.Enabled = false;
        }

        public void nuevo()
        {
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;
            btnRegistrar.Enabled = true;
            btnBuscar.Enabled = true;

            tbId.Enabled = true;
            tbColor.Enabled = true;
        }

        public void limpiar()
        {
            tbId.Text = "";
            tbColor.Text = "";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            color = new Color();
            btnModificar.Enabled = true;
            int id = 0;
            int.TryParse(tbId.Text, out id);

            if (tbId.Text == string.Empty)
            {
                Msg.Text = "Error, debe digitar un Id para realizar la busqueda";
            }else {
            
                    if (color.Buscar(id))
                    {
                        id = color.IdColor;
                        tbColor.Text = color.Descripcion;
                    }
                    else if(!color.Buscar(id))
                    {
                        Msg.Text = "El id no existe..";
                        limpiar();
                    }
            }
            btnEliminar.Enabled = true;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            limpiar();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            color = new Color();

            color.Descripcion = tbColor.Text;
            
            if (tbId.Text != string.Empty)
            {
                Msg.Text = "Error el campo de Id debe estar vacio...";
            } else if (tbColor.Text == string.Empty) {
                Msg.Text = "Error el campo de descripcion no puede estar vacio...";
            } else if(color.Validar(tbColor.Text))
            
            {
                Msg.Text = "El color ya existe..";
                limpiar();
            }else {
                        if(color.insertar()) {
                       
                        Msg.Text = "El registro se ha guardado exitosamente!";
                       
                        }
                }
            }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            color = new Color();

            color.Descripcion = tbColor.Text;

            int id = 0;
            int.TryParse(tbId.Text, out id);

            if (tbColor.Text == string.Empty)
            {
                Msg.Text = "Error, el campo no puede estar vacio!";

            }else{
                    if (color.modificar(id)) 
                    {
                        Msg.Text = "El registro se ha modificado exitosamente!";   
                        
                    }
                }
            deshabilitar();
                limpiar();
            }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            color = new Color();
            int id = 0;

            int.TryParse(tbId.Text, out id);

            if (tbId.Text == null)
            {
                Msg.Text = "Debe digitar un id para eliminar el campo...";
            }
            else
            {
                if (color.eliminar(id))
                {
                    Msg.Text = "El registro se ha eliminado exitosamente!";
                }
            }
            limpiar();
        }
      }
    }
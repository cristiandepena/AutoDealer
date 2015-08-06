using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using System.Data.SqlClient;

namespace AutoRent
{
    public partial class rTransmision : System.Web.UI.Page
    {
         Transmision t = new Transmision();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void InitializeCulture()
        {
            //if (Session["Lang"] != null)
            //{
                
            //    this.UICulture = Session["Lang"].ToString();
            //}
            //else
            //{
            //    this.UICulture = this.UICulture.Substring(0, 2);
            //}
           
            //base.InitializeCulture();

            if (Request.Form["dllLang"] != null)
            {
                UICulture = Request.Form["ddlLang"];
            }
            base.InitializeCulture();
            
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {

            try
            {
                t = new Transmision();

                t.Descripcion = tbDescripcion.Text;
                
                if (t.insertar())
                {
                    Response.Write("Exito!");
                }
                else
                {
                    Response.Write("Fallido");
                }
            }
            catch (SqlException sq)
            {

                Response.Write(sq.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void ddlLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Session["Lang"] = ddlLang.SelectedValue.ToString();
            //Response.Redirect("rTransmision.aspx");
        }
    }
}
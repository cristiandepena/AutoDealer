using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Color
    {
        public int IdColor { get; set; }
        public string Descripcion { get; set; }

        public Conexion con;
        public string comando;

        public Color()
        {
            this.IdColor = 0;
            this.Descripcion = Descripcion;
        }

        public bool insertar()
        {
            comando = "insert into Colores (Descripcion) values ('"+Descripcion+"')";

            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update Colores set Descripcion = '"+Descripcion+"' where IdColor = " + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id) 
        {
            comando = "delete from Colores where IdColor = " + id;

            return con.EjecutarDB(comando);
        }

        public bool Listar()
        {
            DataTable dt;

            comando = "select * from Colores";

            bool msj = false;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdColor = (int)dt.Rows[0]["IdColor"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return msj;
        }
    }
}

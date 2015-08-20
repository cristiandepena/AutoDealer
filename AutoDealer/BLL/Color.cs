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

        public Conexion con = new Conexion();
        public string comando;

        public Color()
        {
            this.IdColor = 0;
            this.Descripcion = Descripcion;
        }

        public bool insertar()
        {
            comando = "insert into Colores (ColorPrincipal) values ('"+Descripcion+"')";

            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update Colores set ColorPrincipal = '"+Descripcion+"' where IdColor = " + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id) 
        {
            comando = "delete from Colores where IdColor = " + id;

            return con.EjecutarDB(comando);
        }

        public bool Buscar(int id)
        {
            DataTable dt;

            bool msj = false;

            comando = "select IdColor, ColorPrincipal from Colores where IdColor = " +id;
            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;
                this.IdColor = (int)dt.Rows[0]["IdColor"];
                this.Descripcion = dt.Rows[0]["ColorPrincipal"].ToString();
            }
            else
            {
                msj = false;
            }

            return msj;
        }

        public bool Listar(string filtro)
        {
            DataTable dt;

            comando = "select IdColor, ColorPrincipal from Colores where ColorPrincipal like '%"+filtro+"%'";

            bool msj = false;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdColor = (int)dt.Rows[0]["IdColor"];
                this.Descripcion = dt.Rows[0]["ColorPrincipal"].ToString();
            }

            return msj;
        }

        public bool Validar(string color1)
        {
            bool msj = false;
            DataTable dt;

            comando = "select ColorPrincipal from Colores where ColorPrincipal = '"+ color1+ "'";
            
            dt = con.BuscarDb(comando);
            
            if (dt.Rows.Count > 0) 
            {
                msj = true;
            }

            return msj;
        }

        public DataTable BuscarLista(String sql)
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb(sql);
            return dt;
        }

    }
}

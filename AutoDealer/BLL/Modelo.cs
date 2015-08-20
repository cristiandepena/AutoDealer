using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Modelo
    {
        public int IdModelo { get; set; }
        public int IdMarca { get; set; }
        public string Descripcion { get; set; }

        public Conexion con;
        public string comando;

        public Modelo(int IdMarca, string Descripcion)
        {
            this.IdMarca = 0;
            this.Descripcion = Descripcion;
        }

        public bool insertar()
        {
            comando = "insert into Modelo (IdMarca, Descripcion) value('"+Descripcion+"')";

            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update Modelo set IdMarca = '"+ IdMarca +"', Descripcion = '" + Descripcion + "' where IdModelo =" + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id)
        {
            comando = "delete from Modelo where IdModelo = " + id;

            return con.EjecutarDB(comando);
        }

        public bool Buscar(int id)
        {
            DataTable dt;

            comando = "select * from Modelos where IdModelo = " + id;

            bool msj = false;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdModelo = (int)dt.Rows[0]["IdModelo"];
                this.IdMarca = (int)dt.Rows[0]["IdMarca"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return msj;
        }

        public bool Listar()
        {
            DataTable dt;

            comando = "select * from Modelos";

            bool msj = false;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdModelo = (int)dt.Rows[0]["IdModelo"];
                this.IdMarca = (int)dt.Rows[0]["IdMarca"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return msj;
        }
    }
}

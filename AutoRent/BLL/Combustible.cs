using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Combustible
    {
        public int IdCombustible { get; set; }
        public string Descripcion { get; set; }

        public Conexion con = new Conexion();
        public string comando;

        public Combustible()
        {
            this.IdCombustible = 0;
            this.Descripcion = Descripcion;
        }

        public bool insertar()
        {
            comando = "insert into Combustibles (Descripcion) values('"+Descripcion+"')";

            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update Combustibles set Descripcion = '" + Descripcion + "' where IdCombustible =" + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id)
        {
            comando = "delete from Combustibles where IdCombustible = " + id;

            return con.EjecutarDB(comando);
        }

        public bool Listar()
        {
            DataTable dt;

            comando = "select * from Combustibles";

            bool msj = false;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdCombustible = (int)dt.Rows[0]["IdCombustible"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return msj;
        }

    }
}

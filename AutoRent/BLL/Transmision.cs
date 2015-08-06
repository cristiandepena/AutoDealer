using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Transmision
    {
        public int IdTransmision { get; set; }
        public string Descripcion { get; set; }

        public Conexion con = new Conexion();

        public Transmision()
        {
            this.IdTransmision = 0;
            this.Descripcion = Descripcion;
        }

        public bool insertar() { return con.EjecutarDB("insert into Transmisiones (Descripcion) values ('"+this.Descripcion+"')");}
        public bool modificar(int id) { return con.EjecutarDB("update Transmisiones set Descripcion = '"+this.Descripcion+"' where IdTransmision = " +id); }
        public bool eliminar(int id) { return con.EjecutarDB("delete Transmisiones where IdTransmision = " + id); }

        public bool BuscarDB(int id)
        {
            DataTable dt;
            bool msj = false;

            dt = con.BuscarDb("select Descripcion from Transmisiones where IdTransmision =" + id);

            if (dt.Rows.Count > 0)
            {
                this.IdTransmision = (int)dt.Rows[0]["IdTransmision"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();

                msj = true;
            }

            return msj;
        }
    }
}

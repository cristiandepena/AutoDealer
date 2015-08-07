using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class TipoVehiculo
    {

        public int IdTipoVehiculo { get; set; }
        public string Descripcion { get; set; }

        public Conexion con;
        public string comando;

        public TipoVehiculo()
        {
            this.IdTipoVehiculo = 0;
            this.Descripcion = Descripcion;
        }

        public bool insertar()
        {
            comando = "insert into TiposVehiculo (Descripcion) value('"+Descripcion+"')";

            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update TiposVehiculo set Descripcion = '"+Descripcion+"' where IdTipoVehiculo = " + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id)
        {
            comando = "delete from TiposVehiculo where IdTipoVehiculo = " + id;

            return con.EjecutarDB(comando);
        }

        public bool Buscar()
        {
            DataTable dt;

            comando = "select * from TiposVehiculo";

            bool msj = false;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdTipoVehiculo = (int)dt.Rows[0]["IdTipoVehiculo"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return msj;
        }
    }
}

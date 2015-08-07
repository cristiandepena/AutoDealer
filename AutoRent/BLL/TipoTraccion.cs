using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class TipoTraccion
    {
        public int IdTipoTraccion { get; set; }
        public string Descripcion { get; set; }

        public Conexion con;
        public string comando;

        public TipoTraccion()
        {
            this.IdTipoTraccion = 0;
            this.Descripcion = Descripcion;
        }

        public bool insertar()
        {
            comando = "insert into TipoTraccion (Descripcion) value('"+Descripcion+"')";

            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update TipoTraccion set Descripcion = '"+Descripcion+"' where IdTipoTraccion = " + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id)
        {
            comando = "delete from TipoTraccion where IdTipoTraccion = " + id;

            return con.EjecutarDB(comando);
        }

        public bool Buscar()
        {
            DataTable dt;

            comando = "select * from TipoTraccion";

            bool msj = false;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdTipoTraccion = (int)dt.Rows[0]["IdTipoTraccion"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }

            return msj;
        }
    }
}

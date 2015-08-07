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
        public string DetalleModelo { get; set; }

        public Conexion con;
        public string comando;

        public Modelo()
        {
            this.IdModelo = 0;
            this.DetalleModelo = DetalleModelo;
        }

        public bool insertar()
        {
            comando = "insert into Modelo (DetalleModelo) value('"+DetalleModelo+"')";

            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update Modelo set DetalleModelo = '" + DetalleModelo + "' where IdModelo =" + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id)
        {
            comando = "delete from Modelo where IdModelo = " + id;

            return con.EjecutarDB(comando);
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
                this.DetalleModelo = dt.Rows[0]["DetalleModelo"].ToString();
            }

            return msj;
        }
    }
}

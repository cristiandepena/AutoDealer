using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Marca
    {
        public int IdMarca { get; set; }
        public string DetalleModelo { get; set; }

        public Conexion con;
        public string comando;

        public Marca()
        {
            this.IdMarca = 0;
            this.DetalleModelo = DetalleModelo;
        }

        public bool insertar()
        {
            comando = "insert into Marcas (DetalleModelo) value('"+DetalleModelo+"')";

            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update Marcas set DetalleModelo = '"+DetalleModelo+"' where IdMarca = " + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id)
        {
            comando = "delete from Marcas where IdMarca = " + id;

            return con.EjecutarDB(comando);
        }

        public bool Buscar()
        {
            DataTable dt;

            comando = "select * from Marcas ";

            bool msj = false;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdMarca = (int)dt.Rows[0]["IdMarca"];
                this.DetalleModelo = dt.Rows[0]["DetalleModelo"].ToString();
            }

            return msj;
        }
    }
}

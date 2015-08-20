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
        public List<Modelo> modelos;

        public Conexion con = new Conexion();
        public string comando;

        public Marca()
        {
            this.IdMarca = 0;
            this.DetalleModelo = DetalleModelo;
            this.modelos = new List<Modelo>();
        }

        public bool insertar()
        {
            comando = "insert into Marcas (Descripcion) values('"+DetalleModelo+"')";

            foreach (Modelo model in modelos)
            {
                comando += "insert into Modelos (IdMarca, Descripcion) values('" + model.IdMarca + "', '" + model.Descripcion + "')";
            }
            return con.EjecutarDB(comando);
        }

        public void AgregarModelo(int IdMarca, string Descripcion)
        {
            this.modelos.Add(new Modelo(IdMarca, Descripcion));
        }

        public bool modificar(int id)
        {
            comando = "update Marcas set Descripcion = '"+DetalleModelo+"' where IdMarca = " + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id)
        {
            comando = "delete from Marcas where IdMarca = " + id;

            return con.EjecutarDB(comando);
        }

        public bool Buscar(int id)
        {
            DataTable dt;

            comando = "select * from Marcas where IdMarca = " +id;

            bool msj = false;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdMarca = (int)dt.Rows[0]["IdMarca"];
                this.DetalleModelo = dt.Rows[0]["Descripcion"].ToString();
            }

            return msj;
        }

        public DataTable Listar(string sql)
        {
            comando = sql;

            return con.BuscarDb(comando);
        }
    }
}

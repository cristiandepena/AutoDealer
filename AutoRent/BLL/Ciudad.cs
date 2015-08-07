using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Ciudad
    {
        public int IdCiudad { get; set; }
        public string NombreCiudad { get; set; }

        public Conexion con;
        public string comando;

        public Ciudad()
        {
            this.IdCiudad = 0;
            this.NombreCiudad = NombreCiudad;
        }

        public bool insertar()
        {
            comando = "insert into Ciudades (NombreCiudad) values('"+NombreCiudad+"')";

            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update Ciudades set NombreCiudad = '"+NombreCiudad+"' where IdCiudad = " +id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id)
        {
            comando = "delete Ciudades where IdCiudad = " +id;

            return con.EjecutarDB(comando);

        }

        public bool Buscar(int id)
        {
            comando = "select * from Ciudades where IdCiudad = " + id;

            DataTable dt;

            dt = con.BuscarDb(comando);

            bool msj = false;

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdCiudad = (int)dt.Rows[0]["IdCiudad"];
                this.NombreCiudad = dt.Rows[0]["NombreCiudad"].ToString();
            }

            return msj;
        }

        public DataTable Listar() 
        {
            comando = "select NombreCiudad from Ciudades";

            return con.BuscarDb(comando);
        }
    }
}

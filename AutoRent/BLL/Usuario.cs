using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdCiudad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Activo;

        public Conexion con = new Conexion();
        public string comando;

        public Usuario()
        {
            this.IdUsuario = 0;
            this.NombreUsuario = NombreUsuario;
            this.Contrasena = Contrasena;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Cedula = Cedula;
            this.Direccion = Direccion;
            this.Correo = Correo;
            this.Telefono = Telefono;
            this.FechaNacimiento = FechaNacimiento.Date;
            this.IdCiudad = 0;
            this.FechaIngreso = DateTime.Now;
            this.Activo = true;
        }

        public bool insertar() {
            
            comando = "insert into Usuarios (NombreUsuario, Contrasena, Nombre, Apellido, Cedula, Direccion, Correo,"
            +"Telefono, FechaNacimiento, IdCiudad, FechaIngreso, Activo) values ( '"+this.NombreUsuario+"', "
            +"'"+this.Contrasena+"', '"+this.Nombre+"', '"+this.Apellido+"', '"+this.Cedula+"', '"+this.Telefono+"'," 
            +"'"+this.Direccion+"', '"+this.Correo+"', '"+this.FechaNacimiento.ToString("dd/MM/yyyy")+"', '"+this.IdCiudad+"'," 
            +"'"+this.FechaIngreso+"', '"+this.Activo+"')";

            return con.EjecutarDB(comando); 
        }

        public bool modificar(int id) { 

            comando = "update Usuarios set Contrasena = '"+this.Contrasena+"', Nombre = '"+this.Nombre+"'," 
            +"Apellido = '"+this.Apellido+"', Cedula = '"+this.Cedula+"', Direccion = '"+this.Direccion+"'," 
            +"Telefono = '"+this.Telefono+"', FechaNacimiento = '"+this.FechaNacimiento.ToString("dd/MM/yyyy")+"'," 
            +"IdCiudad = '"+this.IdCiudad+"', Activo = '"+this.Activo+"' where IdUsuario = " +id;
            
            return con.EjecutarDB(comando); 
        }
        public bool eliminar(int id) {

            comando = "delete from Usuarios where IdUsuario = " + id;

            return con.EjecutarDB(comando); 
        }

        public bool Buscar(int id)
        {
            DataTable dt;

            bool msj = false;

            comando = "select * from Usuarios where IdUsuario = " + id;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                this.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.Apellido = dt.Rows[0]["Apellido"].ToString();
                this.Cedula = dt.Rows[0]["Cedula"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();
                this.Correo = dt.Rows[0]["Correo"].ToString();
                this.Telefono = dt.Rows[0]["Telefono"].ToString();
                this.IdCiudad = (int)dt.Rows[0]["IdCiudad"];
                this.FechaNacimiento = (DateTime)dt.Rows[0]["FechaNacimiento"];
                this.Activo = (bool)dt.Rows[0]["Activo"];

                msj = true;
            }
            return msj;
        }
    }
}

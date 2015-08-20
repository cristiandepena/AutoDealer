using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public string Descripcion { get; set; }
        public int IdCondicion { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo {get; set;}
        public int IdTransmision { get; set; }
        public int IdTipoTraccion { get; set; }
        public int IdTipoVehiculo { get; set; }
        public int AnoFabricacion { get; set; }
        public float Precio { get; set; }
        public int IdCombustible { get; set; }
        public int IdColor { get; set; }
        public int IdUsuario { get; set; }
        public bool Activo { get; set; }

        public Conexion con;
        public string comando;
        public List<Imagen> imagenes { get; set; }

        public Vehiculo()
        {
            this.IdVehiculo = 0;
            this.Descripcion = Descripcion;
            this.IdCondicion = 0;
            this.IdMarca = 0;
            this.IdModelo = 0;
            this.IdTransmision = 0;
            this.IdTipoTraccion = 0;
            this.IdTipoVehiculo = 0;
            this.AnoFabricacion = 0;
            this.Precio = 0.00f;
            this.IdCombustible = 0;
            this.IdColor = 0;
            this.IdUsuario = 0;
            this.Activo = true;
            con = new Conexion();
            imagenes = new List<Imagen>();
        }

        public bool insertar()
        {
   
            comando = "insert into Vehiculos (Descripcion, IdCondicion, IdMarca, IdModelo, IdTransmision, IdTipoTraccion,"
            +"IdTipoVehiculo, AnoFabricacion, Precio, IdCombustible, IdColor, IdUsuario, Activo) values"
            + "('" + Descripcion + "', '" + IdCondicion + "',  '" + IdMarca + "', '" + IdModelo + "', '" + IdTransmision + "',"
            + "'" + IdTipoTraccion + "', '" + IdTipoVehiculo + "', '" + AnoFabricacion + "', '" + Precio + "',"
            + "'" + IdCombustible + "', '" + IdColor + "', '" + IdUsuario + "', '" + Activo + "')";

            foreach (Imagen img in imagenes)
            {
                comando += "insert into Vehiculos_Imagenes (IdVehiculo, RutaFoto) values((select max(IdVehiculo) as IdVehiculo from Vehiculos), '"+img.rutaFoto+"')";
            }
            return con.EjecutarDB(comando);
        }

        public bool modificar(int id)
        {
            comando = "update Vehiculos set Descripcion = '"+ Descripcion+"', IdCondicion = '" + IdCondicion + "', IdMarca = '" + IdMarca + "', IdModelo = '" + IdModelo + "',"
            + "IdTransmision = '" + IdTransmision + "', IdTipoTraccion = '" + IdTipoTraccion + "', IdTipoVehiculo = '" + IdTipoVehiculo + "',"
            + "AnoFabricacion = '" + AnoFabricacion + "', Precio = '" + Precio + "', IdCombustible = '" + IdCombustible + "', IdColor = '" + IdColor + "',"
            + "IdUsuario = '" + IdUsuario + "', Activo = '" + Activo + "' where IdVehiculo = " + id;

            return con.EjecutarDB(comando);
        }

        public bool eliminar(int id)
        {
            comando = "delete from Vehiculos where IdVehiculo = " + id;

            return con.EjecutarDB(comando);
        }

        public bool Buscar(int id)
        {
            DataTable dt;

            bool msj = false;

            comando = "select * from Vehiculos where IdVehiculo = " + id;

            dt = con.BuscarDb(comando);

            if (dt.Rows.Count > 0)
            {
                msj = true;

                this.IdVehiculo = (int)dt.Rows[0]["IdVehiculo"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.IdCondicion = (int)dt.Rows[0]["IdCondicion"];
                this.IdMarca = (int)dt.Rows[0]["IdMarca"];
                this.IdModelo = (int)dt.Rows[0]["IdModelo"];
                this.IdTransmision = (int)dt.Rows[0]["IdTransmision"];
                this.IdTipoTraccion = (int)dt.Rows[0]["IdTipoTraccion"];
                this.IdTipoVehiculo = (int)dt.Rows[0]["IdTipoVehiculo"];
                this.AnoFabricacion = (int)dt.Rows[0]["AnoFabricacion"];
                this.Precio = (float)dt.Rows[0]["Precio"];
                this.IdCombustible = (int)dt.Rows[0]["IdCombustible"];
                this.IdColor = (int)dt.Rows[0]["IdColor"];
                this.IdUsuario = (int)dt.Rows[0]["IdUsuario"];
                this.Activo = (bool)dt.Rows[0]["Activo"];
            }
           
            return msj;
        }

        public DataTable Listar(string campos, string filtroWhere)
        {
            comando = "select"+ campos +"from Vehiculos where "+campos+" like '%"+filtroWhere+"%'";

            return con.BuscarDb(comando);
        }

    }
}

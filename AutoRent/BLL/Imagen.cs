using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Imagen
    {
        public int IdImagen { get; set; }
        public int IdVehiculo { get; set; }
        public byte[] rutaFoto { get; set; }

        public Imagen(int IdVehiculo, byte[] ruta)
        {
            this.IdVehiculo = 0;
            this.rutaFoto = rutaFoto;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoHeladeria.Models
{
    public class DetalleVentascs
    {
        public int idDetalleVentas { get; set; }
        public int Productos_idProductos { get; set; }
        public int Ventas_idVentas { get; set; }

    }
}

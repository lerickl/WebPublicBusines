using System;
using System.Collections.Generic;

namespace WebApplication1.DataDb
{
    public partial class Servicio
    {
        public int? ServicioId { get; set; }
        public string? NombreServicio { get; set; }
        public string? PrecioServicio { get; set; }
        public int? EmpresaId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebApplication1.DataDb
{
    public partial class Servicio
    {
        public int? ServicioId { get; set; }
        public string? Nombre { get; set; }
        public string? Precio { get; set; }
        public int? EmpresaId { get; set; }
        public string? TipoServicio { get; set; }
        public string? Descripcion { get; set; }
        public string? ImagenS { get; set; }
    }
}

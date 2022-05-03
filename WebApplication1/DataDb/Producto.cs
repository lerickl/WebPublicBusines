using System;
using System.Collections.Generic;

namespace WebApplication1.DataDb
{
    public partial class Producto
    {
        public int? ProductoId { get; set; }
        public string? Nombre { get; set; }
        public string? Precio { get; set; }
        public int? EmpresaId { get; set; }
    }
}

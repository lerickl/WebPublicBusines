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
        public string? Marca { get; set; }
        public string? Descripcion { get; set; }
        public string? ImagenP { get; set; }
        public int? CategoriaId { get; set; }
    }
}

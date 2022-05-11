using System;
using System.Collections.Generic;

namespace WebApplication1.DataDb
{
    public partial class Categoria
    {
        public int? CategoriaId { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? EmpresaId { get; set; }
    }
}

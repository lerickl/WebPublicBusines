using System;
using System.Collections.Generic;

namespace WebApplication1.DataDb
{
    public partial class Empresa
    {
        public int? EmpresaId { get; set; }
        public string? NombreComercial { get; set; }
        public string? Puntuacion { get; set; }
        public string? Ruc { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public int? CategoriaId { get; set; }
    }
}

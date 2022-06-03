using System;
using System.Collections.Generic;

namespace WebApplication1.DataDb
{
    public partial class Comentario
    {
        public int? ComentarioId { get; set; }
        public string? Contenido { get; set; }
        public int? UsuarioId { get; set; }
        public int? EmpresaId { get; set; }
        public int? ProductoId { get; set; }
        public int? ServicioId { get; set; }
        public string? Abierto { get; set; } 
    }
}

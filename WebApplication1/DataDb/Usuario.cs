using System;
using System.Collections.Generic;

namespace WebApplication1.DataDb
{
    public partial class Usuario
    {
        public int? UsuarioId { get; set; }
        public string? Nombres { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Usuarioname { get; set; }
        public string? Contraseña { get; set; }
        public string? Email { get; set; }
        /*public virtual List<Categoria>? Categorias { get; set; }
        public virtual List<Comentario>? Comentarios { get; set; }
        public virtual List<Favorito>? Favoritos { get; set; }*/



    }
}

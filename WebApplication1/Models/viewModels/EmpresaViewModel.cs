namespace WebApplication1.Models.viewModels
{
    public class EmpresaViewModel
    {
        public IFormFile? imgperfil { get; set; }
        public string? NombreComercial { get; set; }
        public string? Puntuacion { get; set; }
        public string? Ruc { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? CategoriaId { get; set; }
    }
}

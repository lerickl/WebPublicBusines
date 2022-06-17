namespace WebApplication1.Models.viewModels
{
    public class ServicioViewModel
    {
        public int ServicioId { get; set; }
        public IFormFile? imgperfilServicio { get; set; }
        public string? EditImg { get; set; }
        public string? Nombre { get; set; }
        public string? Precio { get; set; }
        public string? TipoServicio { get; set; }
        public string? Descripcion { get; set; }
        public int? CategoriaId { get; set; }
      
    }
}

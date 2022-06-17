namespace WebApplication1.Models.viewModels
{
    public class ProductoViewModel
    {
        public int? ProductoId { get; set; }
        public string EditImg { get; set; }
        public IFormFile imgperfilProducto { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int Categoria { get; set; }
    }
}

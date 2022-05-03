using WebApplication1.Models;

namespace WebApplication1.Servicios.Interfaces
{
    public interface IComentarioService
    {
        void AddComentario(Comentario comentario);
        Comentario GetComentarioByID(int? IdComentario);

        IEnumerable<Comentario> GetAllComentario();

        void EditarComentario(int idComentario, Comentario comentario);


    }
}

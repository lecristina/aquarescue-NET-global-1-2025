using AquaRescue.Models;

namespace AquaRescue.Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);
        List<Usuario> Listar();
        Usuario? BuscarPorEmailSenha(string email, string senha);

        Usuario? BuscarPorId(int id);
        void Atualizar(Usuario usuario);
        void Remover(int id);
    }
}

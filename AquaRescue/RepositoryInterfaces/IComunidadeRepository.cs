using AquaRescue.Models;

namespace AquaRescue.Repository.Interfaces
{
    public interface IComunidadeRepository
    {
        void Cadastrar(Comunidade comunidade);
        List<Comunidade> Listar();

        Comunidade? BuscarPorId(int id);
        void Atualizar(Comunidade comunidade);
        void Remover(int id);
    }
}

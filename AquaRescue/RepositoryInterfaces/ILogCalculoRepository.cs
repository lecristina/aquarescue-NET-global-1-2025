using AquaRescue.Models;

namespace AquaRescue.Repository.Interfaces
{
    public interface ILogCalculoRepository
    {
        void Criar(LogCalculo log);
        List<LogCalculo> BuscarPorComunidade(int comunidadeId);

        LogCalculo? BuscarPorId(int id);
        void Atualizar(LogCalculo log);
        void Remover(int id);
    }
}

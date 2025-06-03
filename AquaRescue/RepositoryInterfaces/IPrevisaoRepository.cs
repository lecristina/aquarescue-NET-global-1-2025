using AquaRescue.Models;

namespace AquaRescue.Repository.Interfaces
{
    public interface IPrevisaoRepository
    {
        void Criar(Previsao previsao);
        List<Previsao> BuscarPorComunidade(int comunidadeId);

        Previsao? BuscarPorId(int id);
        void Atualizar(Previsao previsao);
        void Remover(int id);
    }
}

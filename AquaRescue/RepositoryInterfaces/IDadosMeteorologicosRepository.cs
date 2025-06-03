using AquaRescue.Models;

namespace AquaRescue.Repository.Interfaces
{
    public interface IDadosMeteorologicosRepository
    {
        void Criar(DadosMeteorologicos dados);
        List<DadosMeteorologicos> BuscarPorComunidade(int comunidadeId);

        DadosMeteorologicos? BuscarPorId(int id);
        void Atualizar(DadosMeteorologicos dados);
        void Remover(int id);
    }
}

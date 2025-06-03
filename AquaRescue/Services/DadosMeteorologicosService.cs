using AquaRescue.Models;
using AquaRescue.Repository.Interfaces;

namespace AquaRescue.Services
{
    public class DadosMeteorologicosService
    {
        private readonly IDadosMeteorologicosRepository _repository;

        public DadosMeteorologicosService(IDadosMeteorologicosRepository repository)
        {
            _repository = repository;
        }

        public void Criar(DadosMeteorologicos dados)
        {
            _repository.Criar(dados);
        }

        public List<DadosMeteorologicos> BuscarPorComunidade(int comunidadeId)
        {
            return _repository.BuscarPorComunidade(comunidadeId);
        }

        public DadosMeteorologicos? BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public void Atualizar(DadosMeteorologicos dados)
        {
            _repository.Atualizar(dados);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}

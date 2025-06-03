using AquaRescue.Models;
using AquaRescue.Repository.Interfaces;

namespace AquaRescue.Services
{
    public class PrevisaoService
    {
        private readonly IPrevisaoRepository _repository;

        public PrevisaoService(IPrevisaoRepository repository)
        {
            _repository = repository;
        }

        public void Criar(Previsao previsao)
        {
            _repository.Criar(previsao);
        }

        public List<Previsao> BuscarPorComunidade(int comunidadeId)
        {
            return _repository.BuscarPorComunidade(comunidadeId);
        }

        public Previsao? BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public void Atualizar(Previsao previsao)
        {
            _repository.Atualizar(previsao);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}

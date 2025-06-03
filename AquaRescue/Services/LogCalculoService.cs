using AquaRescue.Models;
using AquaRescue.Repository.Interfaces;

namespace AquaRescue.Services
{
    public class LogCalculoService
    {
        private readonly ILogCalculoRepository _repository;

        public LogCalculoService(ILogCalculoRepository repository)
        {
            _repository = repository;
        }

        public void Criar(LogCalculo log)
        {
            _repository.Criar(log);
        }

        public List<LogCalculo> BuscarPorComunidade(int comunidadeId)
        {
            return _repository.BuscarPorComunidade(comunidadeId);
        }

        public LogCalculo? BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public void Atualizar(LogCalculo log)
        {
            _repository.Atualizar(log);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}

using AquaRescue.Models;
using AquaRescue.Repository.Interfaces;

namespace AquaRescue.Services
{
    public class ComunidadeService
    {
        private readonly IComunidadeRepository _repository;

        public ComunidadeService(IComunidadeRepository repository)
        {
            _repository = repository;
        }

        public void Cadastrar(Comunidade comunidade)
        {
            _repository.Cadastrar(comunidade);
        }

        public List<Comunidade> Listar()
        {
            return _repository.Listar();
        }

        public Comunidade? BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public void Atualizar(Comunidade comunidade)
        {
            _repository.Atualizar(comunidade);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}

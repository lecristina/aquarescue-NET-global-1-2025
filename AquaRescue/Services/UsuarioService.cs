using AquaRescue.Models;
using AquaRescue.Repository.Interfaces;

namespace AquaRescue.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public void Cadastrar(Usuario usuario)
        {
            _repository.Cadastrar(usuario);
        }

        public List<Usuario> Listar()
        {
            return _repository.Listar();
        }

        public Usuario? Login(string email, string senha)
        {
            return _repository.BuscarPorEmailSenha(email, senha);
        }

        public Usuario? BuscarPorId(int id)
        {
            return _repository.BuscarPorId(id);
        }

        public void Atualizar(Usuario usuario)
        {
            _repository.Atualizar(usuario);
        }

        public void Remover(int id)
        {
            _repository.Remover(id);
        }
    }
}

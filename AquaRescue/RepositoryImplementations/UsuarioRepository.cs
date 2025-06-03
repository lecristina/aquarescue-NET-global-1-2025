using AquaRescue.Models;
using AquaRescue.Data;
using AquaRescue.Repository.Interfaces;

namespace AquaRescue.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AquaRescueDbContext _context;

        public UsuarioRepository(AquaRescueDbContext context)
        {
            _context = context;
        }

        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario? BuscarPorEmailSenha(string email, string senha)
        {
            return _context.Usuarios
                .FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario? BuscarPorId(int id)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Id == id);
        }

        public void Atualizar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}

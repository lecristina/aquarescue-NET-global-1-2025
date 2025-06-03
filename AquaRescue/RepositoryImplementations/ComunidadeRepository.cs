using AquaRescue.Data;
using AquaRescue.Models;
using AquaRescue.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AquaRescue.Repository
{
    public class ComunidadeRepository : IComunidadeRepository
    {
        private readonly AquaRescueDbContext _context;

        public ComunidadeRepository(AquaRescueDbContext context)
        {
            _context = context;
        }

        public void Cadastrar(Comunidade comunidade)
        {
            _context.Comunidades.Add(comunidade);
            _context.SaveChanges();
        }

        public List<Comunidade> Listar()
        {
            return _context.Comunidades.ToList();
        }

        public Comunidade? BuscarPorId(int id)
        {
            return _context.Comunidades.FirstOrDefault(c => c.Id == id);
        }

        public void Atualizar(Comunidade comunidade)
        {
            _context.Comunidades.Update(comunidade);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var comunidade = _context.Comunidades.FirstOrDefault(c => c.Id == id);
            if (comunidade != null)
            {
                _context.Comunidades.Remove(comunidade);
                _context.SaveChanges();
            }
        }
    }
}

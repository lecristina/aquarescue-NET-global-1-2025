using AquaRescue.Data;
using AquaRescue.Models;
using AquaRescue.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AquaRescue.Repository
{
    public class DadosMeteorologicosRepository : IDadosMeteorologicosRepository
    {
        private readonly AquaRescueDbContext _context;

        public DadosMeteorologicosRepository(AquaRescueDbContext context)
        {
            _context = context;
        }

        public void Criar(DadosMeteorologicos dados)
        {
            _context.DadosMeteorologicos.Add(dados);
            _context.SaveChanges();
        }

        public List<DadosMeteorologicos> BuscarPorComunidade(int comunidadeId)
        {
            return _context.DadosMeteorologicos.Where(d => d.ComunidadeId == comunidadeId).ToList();
        }

        public DadosMeteorologicos? BuscarPorId(int id)
        {
            return _context.DadosMeteorologicos.FirstOrDefault(d => d.Id == id);
        }

        public void Atualizar(DadosMeteorologicos dados)
        {
            _context.DadosMeteorologicos.Update(dados);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var dados = _context.DadosMeteorologicos.FirstOrDefault(d => d.Id == id);
            if (dados != null)
            {
                _context.DadosMeteorologicos.Remove(dados);
                _context.SaveChanges();
            }
        }
    }
}

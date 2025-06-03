using Microsoft.AspNetCore.Mvc;
using AquaRescue.Models;
using AquaRescue.Services;

namespace AquaRescue.Controllers
{
    [ApiController]
    [Route("api/comunidades")]
    public class ComunidadeController : ControllerBase
    {
        private readonly ComunidadeService _service;

        public ComunidadeController(ComunidadeService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Comunidade comunidade)
        {
            _service.Cadastrar(comunidade);
            return Created("", comunidade);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_service.Listar());
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] Comunidade dto)
        {
            var existente = _service.BuscarPorId(id);
            if (existente == null) return NotFound("Comunidade não encontrada");

            existente.Nome = dto.Nome;
            existente.Latitude = dto.Latitude;
            existente.Longitude = dto.Longitude;
            existente.QtHabitantes = dto.QtHabitantes;

            _service.Atualizar(existente);
            return NoContent();
        }



        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var existente = _service.BuscarPorId(id);
            if (existente == null) return NotFound("Comunidade não encontrada");

            _service.Remover(id);
            return NoContent();
        }
    }
}

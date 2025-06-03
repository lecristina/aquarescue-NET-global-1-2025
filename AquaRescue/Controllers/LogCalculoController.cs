using Microsoft.AspNetCore.Mvc;
using AquaRescue.Models;
using AquaRescue.Services;
using AquaRescue.DTO;

namespace AquaRescue.Controllers
{
    [ApiController]
    [Route("api/logs-calculo")]
    public class LogCalculoController : ControllerBase
    {
        private readonly LogCalculoService _service;

        public LogCalculoController(LogCalculoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Criar([FromBody] LogCalculoDTO dto)
        {
            var log = new LogCalculo
            {
                ComunidadeId = dto.ComunidadeId,
                DataCalculo = dto.DataCalculo,
                QtHabitantes = dto.QtHabitantes,
                ConsumoPorPessoa = dto.ConsumoPorPessoa,
                TotalVolume = dto.TotalVolume
            };

            _service.Criar(log);
            return Created("", log);
        }

        [HttpGet("comunidade/{id}")]
        public IActionResult BuscarPorComunidade(int id)
        {
            return Ok(_service.BuscarPorComunidade(id));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] LogCalculoDTO dto)
        {
            var existente = _service.BuscarPorId(id);
            if (existente == null) return NotFound("Log não encontrado");

            existente.ComunidadeId = dto.ComunidadeId;
            existente.DataCalculo = dto.DataCalculo;
            existente.QtHabitantes = dto.QtHabitantes;
            existente.ConsumoPorPessoa = dto.ConsumoPorPessoa;
            existente.TotalVolume = dto.TotalVolume;

            _service.Atualizar(existente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var existente = _service.BuscarPorId(id);
            if (existente == null) return NotFound("Log não encontrado");

            _service.Remover(id);
            return NoContent();
        }
    }
}

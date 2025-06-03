using Microsoft.AspNetCore.Mvc;
using AquaRescue.Models;
using AquaRescue.Services;
using AquaRescue.DTO;

namespace AquaRescue.Controllers
{
    [ApiController]
    [Route("api/previsoes")]
    public class PrevisaoController : ControllerBase
    {
        private readonly PrevisaoService _service;

        public PrevisaoController(PrevisaoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Criar([FromBody] PrevisaoDTO dto)
        {
            var previsao = new Previsao
            {
                ComunidadeId = dto.ComunidadeId,
                Temperatura = dto.Temperatura,
                Umidade = dto.Umidade,
                VolumePrevisto = dto.VolumePrevisto,
                DataPrevisao = dto.DataPrevisao
            };

            _service.Criar(previsao);
            return Created("", previsao);
        }

        [HttpGet("comunidade/{id}")]
        public IActionResult BuscarPorComunidade(int id)
        {
            return Ok(_service.BuscarPorComunidade(id));
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] PrevisaoDTO dto)
        {
            var existente = _service.BuscarPorId(id);
            if (existente == null) return NotFound("Previsão não encontrada");

            existente.ComunidadeId = dto.ComunidadeId;
            existente.Temperatura = dto.Temperatura;
            existente.Umidade = dto.Umidade;
            existente.VolumePrevisto = dto.VolumePrevisto;
            existente.DataPrevisao = dto.DataPrevisao;

            _service.Atualizar(existente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var existente = _service.BuscarPorId(id);
            if (existente == null) return NotFound("Previsão não encontrada");

            _service.Remover(id);
            return NoContent();
        }
    }
}

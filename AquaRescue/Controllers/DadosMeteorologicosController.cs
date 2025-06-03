using Microsoft.AspNetCore.Mvc;
using AquaRescue.Models;
using AquaRescue.Services;
using AquaRescue.DTO;

namespace AquaRescue.Controllers
{
    [ApiController]
    [Route("api/dados-meteorologicos")]
    public class DadosMeteorologicosController : ControllerBase
    {
        private readonly DadosMeteorologicosService _service;

        public DadosMeteorologicosController(DadosMeteorologicosService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Criar([FromBody] DadosMeteorologicosDTO dto)
        {
            var dados = new DadosMeteorologicos
            {
                ComunidadeId = dto.ComunidadeId,
                DataHora = dto.DataHora,
                Temperatura = dto.Temperatura,
                Umidade = dto.Umidade,
                PtoOrvalho = dto.PtoOrvalho,
                Pressao = dto.Pressao,
                VentoVeloc = dto.VentoVeloc,
                VentoDirecao = dto.VentoDirecao,
                VentoRajada = dto.VentoRajada,
                Radiacao = dto.Radiacao,
                Chuva = dto.Chuva
            };

            _service.Criar(dados);
            return Created("", dados);
        }

        [HttpGet("comunidade/{id}")]
        public IActionResult BuscarPorComunidade(int id)
        {
            var registros = _service.BuscarPorComunidade(id);
            return Ok(registros);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] DadosMeteorologicosDTO dto)
        {
            var existente = _service.BuscarPorId(id);
            if (existente == null) return NotFound("Registro não encontrado");

            existente.ComunidadeId = dto.ComunidadeId;
            existente.DataHora = dto.DataHora;
            existente.Temperatura = dto.Temperatura;
            existente.Umidade = dto.Umidade;
            existente.PtoOrvalho = dto.PtoOrvalho;
            existente.Pressao = dto.Pressao;
            existente.VentoVeloc = dto.VentoVeloc;
            existente.VentoDirecao = dto.VentoDirecao;
            existente.VentoRajada = dto.VentoRajada;
            existente.Radiacao = dto.Radiacao;
            existente.Chuva = dto.Chuva;

            _service.Atualizar(existente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var existente = _service.BuscarPorId(id);
            if (existente == null) return NotFound("Registro não encontrado");

            _service.Remover(id);
            return NoContent();
        }
    }
}

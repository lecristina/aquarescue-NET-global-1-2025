using Microsoft.AspNetCore.Mvc;
using AquaRescue.Models;
using AquaRescue.Services;
using AquaRescue.DTO;

namespace AquaRescue.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _service;

        public UsuarioController(UsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] UsuarioDTO usuarioDto)
        {
            var usuario = new Usuario
            {
                Nome = usuarioDto.Nome,
                Email = usuarioDto.Email,
                Senha = usuarioDto.Senha,
                Tipo = usuarioDto.Tipo
            };

            _service.Cadastrar(usuario);
            return Created("", usuario);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_service.Listar());
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] UsuarioDTO usuarioDto)
        {
            var usuarioExistente = _service.BuscarPorId(id);
            if (usuarioExistente == null)
                return NotFound("Usuário não encontrado");

            usuarioExistente.Nome = usuarioDto.Nome;
            usuarioExistente.Email = usuarioDto.Email;
            usuarioExistente.Senha = usuarioDto.Senha;
            usuarioExistente.Tipo = usuarioDto.Tipo;

            _service.Atualizar(usuarioExistente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var usuarioExistente = _service.BuscarPorId(id);
            if (usuarioExistente == null)
                return NotFound("Usuário não encontrado");

            _service.Remover(id);
            return NoContent();
        }
    }
}

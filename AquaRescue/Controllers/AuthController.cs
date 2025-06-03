using Microsoft.AspNetCore.Mvc;
using AquaRescue.DTO;
using AquaRescue.Services;

namespace AquaRescue.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly UsuarioService _service;

        public AuthController(UsuarioService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO login)
        {
            var usuario = _service.Login(login.Email, login.Senha);
            if (usuario == null)
                return Unauthorized("Credenciais inválidas.");

            return Ok(new LoginResponseDTO
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Tipo = usuario.Tipo
            });
        }
    }
}

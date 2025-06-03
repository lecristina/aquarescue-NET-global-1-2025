using System.ComponentModel.DataAnnotations;

namespace AquaRescue.DTO
{
    public class UsuarioDTO
    {

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
        public string Senha { get; set; }

        public string Tipo { get; set; }
    }
}

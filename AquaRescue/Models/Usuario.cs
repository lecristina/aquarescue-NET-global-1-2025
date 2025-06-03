using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaRescue.Models
{
    [Table("T_AQUA_USUARIO")]
    public class Usuario
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NOME")]
        public string Nome { get; set; } = string.Empty;

        [Column("EMAIL")]
        public string Email { get; set; } = string.Empty;

        [Column("SENHA")]
        public string Senha { get; set; } = string.Empty;

        [Column("TIPO")]
        public string Tipo { get; set; } = string.Empty;
    }
}


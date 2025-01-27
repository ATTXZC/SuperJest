using System.ComponentModel.DataAnnotations;

namespace Eco_life.Models
{
    public class Funcionario
    {
        [Key]
        public int Id_Funcionario { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome_Funcionario { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Email_Funcionario { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Senha_Funcionario { get; set; }

        public string? Token { get; set; }
    }
}

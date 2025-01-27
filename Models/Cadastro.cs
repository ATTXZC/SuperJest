﻿using System.ComponentModel.DataAnnotations;

namespace Eco_life.Models
{
    public class Cadastros
    {
        [Key]
        public int ID_User { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome_User { get; set; }

        [Required] 
        [MaxLength(100)]
        public string? Email_User { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Senha_User { get; set; }

        [Required]
        public int CPF { get; set; }
    }
}

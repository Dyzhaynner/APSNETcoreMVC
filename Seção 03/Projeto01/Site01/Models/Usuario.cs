using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site01.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'E-mail' é obrigatório!")]
        [MaxLength(70, ErrorMessage = "O campo 'E-mail' deve conter o máximo de 70 caracteres!")]
        [EmailAddress(ErrorMessage = "'E-mail' invalido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório!")]
        public string Senha { get; set; }
    }
}

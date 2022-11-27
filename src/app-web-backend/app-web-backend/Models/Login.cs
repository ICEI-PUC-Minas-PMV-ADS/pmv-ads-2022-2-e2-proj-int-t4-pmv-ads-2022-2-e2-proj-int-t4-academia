using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Logins")]
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
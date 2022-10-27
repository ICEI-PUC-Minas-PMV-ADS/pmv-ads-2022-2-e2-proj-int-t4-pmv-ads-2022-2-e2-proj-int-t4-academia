using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace app_web_backend.Models
{
    [Table("Usuario")]

    public class cadastroGostos
    {
        [Key]
        private int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar Nome!")]
        private string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar E-mail!")]
        private string Email { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar Senha!")]
        private string Senha { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar Gênero!")]
        private bool Genero { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar Idade!")]
        private int Idade { get; set; }

        

    }
}

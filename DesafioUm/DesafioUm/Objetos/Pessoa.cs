using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUm.Objetos
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O Nome pode ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório")]
        [RegularExpression(@"^\(\d{2}\)\d{5}-\d{4}$", ErrorMessage = "O Telefone deve estar no formato (xx)xxxxx-xxxx")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório")]
        [StringLength(200, ErrorMessage = "O Endereço pode ter no máximo 200 caracteres")]
        public string Endereço { get; set; }

        public int Id { get; set; }

        override public string ToString()
        {
            return "[Nome: " + Nome + "; Endereço: " + Endereço + "; Telefone: " + Telefone + "]";
        }

    }
}

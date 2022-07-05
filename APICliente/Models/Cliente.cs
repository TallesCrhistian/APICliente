using System.ComponentModel.DataAnnotations;

namespace APICliente.Models
{
    public class Cliente
    {
        public  int Id { get; internal set; }
        [Required (ErrorMessage = "Cpf é obriagtório!")]
        public string? Cpf { get; set; }

        [Required (ErrorMessage = "Nome é obriagtório")]
        public string? Nome { get; set; }

        [Required (ErrorMessage ="Data de Nascimento é obrigatório")]
        public string? DataNascimento { get; set; }
    }
}

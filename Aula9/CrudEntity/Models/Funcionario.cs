using System.ComponentModel.DataAnnotations;

namespace CrudEntity.Models
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        public string? Nome { get; set; }

        [Display(Name = "Data Nascimento")]
        public DateTime DtNasc { get; set; }

        [Display(Name = "Salário")]
        public double Salario { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Senha obrigatória")]
        [StringLength(20, ErrorMessage = "Defina senha entre 5 e 20 caracteres", MinimumLength = 5)]
        public string? Senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [Required(ErrorMessage = "Senha obrigatória")]
        [StringLength(20, ErrorMessage = "Defina senha entre 5 e 20 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Senha")]
        public string? ConfirmaSenha { get; set; }
    }
}

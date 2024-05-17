using System.ComponentModel.DataAnnotations;

namespace ExercicioAula11_CadastroAluno.Models
{
    public class Aluno
    {

        public int AlunoId { get; set; }

        [Required]
        [Display(Name = "Nome do Aluno")]
        public string? AlunoName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime? DadatNascimento{ get; set; }

        [Required]
        public string? Sexo { get; set; }

        [Required]
        public string? Curso { get; set; }
        

        public string? Turma { get; set; }
        

        public string? Telefone { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        
    }
}

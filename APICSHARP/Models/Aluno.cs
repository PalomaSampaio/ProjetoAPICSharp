using System.ComponentModel.DataAnnotations;

namespace APICSHARP.Models
{
    public class Aluno
    {
        [Key]
        [Required (ErrorMessage = "O campo Id é obrigatório.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo Matrícula é obrigatório.")]
        public int Matricula { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string? Email { get; set; }
    }
}

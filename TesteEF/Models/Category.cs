using System.ComponentModel.DataAnnotations;

namespace TesteEF.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(60, ErrorMessage="Este campo deve ter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage="Este campo deve ter entre 3 e 60 caracteres")]
        public string Title { get; set; }
    }
}
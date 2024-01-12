using System.ComponentModel.DataAnnotations;

namespace CrudA.Models
{
    public class CadastroModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "digite o nome do funcionario")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "digite o Email do funcionario")]
        public string Email { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

    }
}

using System.ComponentModel.DataAnnotations;

namespace ProjetoMercado.DTO
{
    public class FornecedorDTO
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Phone(ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }
    }
}
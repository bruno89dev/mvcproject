using System.ComponentModel.DataAnnotations;

namespace ProjetoMercado.DTO
{
    public class CategoriaDTO
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        public string Nome { get; set; }
    }
}
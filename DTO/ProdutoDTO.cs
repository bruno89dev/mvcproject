using System.ComponentModel.DataAnnotations;

namespace ProjetoMercado.DTO
{
    public class ProdutoDTO
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int FornecedorID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public float PrecoDeCusto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public float PrecoDeVenda { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(0,2)]
        public int UnidadeDeMedicao { get; set; }
    }
}
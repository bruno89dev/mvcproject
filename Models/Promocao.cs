namespace ProjetoMercado.Models
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Produto Produto { get; set; }
        public float PorcentagemDeDesconto { get; set; }
        public bool Status { get; set; }
    }
}
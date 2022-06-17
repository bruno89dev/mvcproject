using System;

namespace ProjetoMercado.Models
{
    public class Saida
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public float ValorDaVenda { get; set; }
        public DateTime Data { get; set; }
        public Venda Venda { get; set; }

    }
}
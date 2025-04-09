namespace SneakerStore.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public int QuantidadeAtual { get; set; }
        public int QuantidadeMinima { get; set; }
    }
}

namespace Shared.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string? Imagem { get; set; }

        /* 
        --- Atributos para acessar API externa ---
          
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double DiscountPercentage { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Thumbnail { get; set; }
        public List<string> Images { get; set; }
        */
    }
}

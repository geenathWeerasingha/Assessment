namespace LiveAssessment.Models
{
    public class Variation
    {
        public int VariationId { get; set; }
        public string? VariationName { get; set; }
        public decimal? Price { get; set; }
        public string? Sku { get; set; }
        public int Stock { get; set; }
        public Product Product { get; set; }

    }
}

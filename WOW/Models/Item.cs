namespace WOW.Models
{
    public class Item
    {
        public Guid Id { get; set; } = new();
        public string Name { get; set; } = string.Empty;
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}

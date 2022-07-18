namespace WOW.Models
{
    public class Item
    {
        public string Name { get; set; } = string.Empty;
        public int Count { get; set; }
        public decimal Price { get; set; }
        public Person? PaidBy { get; set; }
        public List<Person>? UsedBy { get; set; } = new();
    }
}

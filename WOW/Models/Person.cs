namespace WOW.Models
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public List<Item>? PaidFor { get; set; } = new();
        public List<Item>? Used { get; set; } = new();
    }
}

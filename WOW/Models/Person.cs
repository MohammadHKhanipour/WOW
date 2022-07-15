namespace WOW.Models
{
    public class Person : BaseModel
    {
        public List<Consumable>? PaidFor { get; set; }
        public List<Consumable>? Used { get; set; }
    }
}

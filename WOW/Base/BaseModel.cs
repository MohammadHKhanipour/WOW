namespace WOW.Base
{
    public class BaseModel
    {
        public Guid Id { get; set; } = new();
        public string Name { get; set; } = String.Empty;
    }
}

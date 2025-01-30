namespace WebAPI.Model
{
    public class Experience
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }

        public Experience(string name, string description, int? price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
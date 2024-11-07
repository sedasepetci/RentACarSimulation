namespace RentACarSimulation.Models
{
    public class Color
    {
        public Color(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
    }
}

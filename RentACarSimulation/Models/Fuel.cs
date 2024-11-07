namespace RentACarSimulation.Models
{
    public class Fuel
    {
        public Fuel(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
    }
}

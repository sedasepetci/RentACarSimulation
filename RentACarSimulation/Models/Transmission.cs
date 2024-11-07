

namespace RentACarSimulation.Models
{
    public class Transmission
    {
        public Transmission(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
    }
}

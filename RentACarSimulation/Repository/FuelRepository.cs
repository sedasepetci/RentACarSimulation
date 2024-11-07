using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;

namespace RentACarSimulation.Repository
{
    public class FuelRepository : IRepository<Fuel>
    {
      
        List<Fuel> fuels=new List<Fuel>()
        {
          new Fuel(1, "Petrol"),
          new Fuel(2, "Dizel"),
          new Fuel(3, "LPG"),
        };
        public IEnumerable<Fuel> GetAll()
        {
            return fuels;
        }
        public Fuel? GetById(int id)
        {
            foreach (Fuel fuel in fuels)
            {
                if (fuel.Id == id)
                {
                    return fuel;
                }
            }
            return null;
        }
        public void Add(Fuel fuel)
        {
            fuels.Add(fuel);
        }
        public void Delete(int id)
        {
            Fuel? deletedFuel = GetById(id);
            if (deletedFuel is null)
            {
                Console.WriteLine("Aradığınız yakıt bulunamadı (Zaten yok).");
                return;
            }

            fuels.Remove(deletedFuel);
            Console.WriteLine($"Yakıt silindi: {deletedFuel.Id}");
        }

        public List<CarDetailDto> GetAllDetails()
        {
            throw new NotImplementedException();
        }
    }
}

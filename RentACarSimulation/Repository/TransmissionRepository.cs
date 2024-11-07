
using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;

namespace RentACarSimulation.Repository
{
    public class TransmissionRepository:IRepository<Transmission>
    {
        private List<Transmission> transmissions = new List<Transmission>
        {
              new Transmission(1, "Manual"),
              new Transmission(2, "Automatic"),
              new Transmission(3, "Semi-Automatic"),
        };
        public IEnumerable<Transmission> GetAll()
        {
            return transmissions;
        }
        public Transmission? GetById(int id)
        {
            foreach (Transmission transmission in transmissions)
            {
                if (transmission.Id == id)
                {
                    return transmission;
                }
            }
            return null;
        }
        public void Add(Transmission transmission)
        {
            transmissions.Add(transmission);
        }
        public void Delete(int id)
        {
           Transmission? deletedTransmission = GetById(id);
            if (deletedTransmission is null)
            {
                Console.WriteLine("Aradığınız araç bulunamadı (Zaten yok).");
                return;
            }

            transmissions.Remove(deletedTransmission);
            Console.WriteLine($"Araç silindi: {deletedTransmission.Id}");
        }

        public List<CarDetailDto> GetAllDetails()
        {
            throw new NotImplementedException();
        }
    }
}

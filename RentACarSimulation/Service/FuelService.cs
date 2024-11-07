
using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;
using RentACarSimulation.Repository;

namespace RentACarSimulation.Service
{
    public class FuelService
    {

        private IRepository<Fuel> fuelRepository = new FuelRepository();

        public void GetAll()
        {
            var fuels = fuelRepository.GetAll();


            foreach (var fuel in fuels)
            {
                Console.WriteLine($"Fuel ID: {fuel.Id},Fuel Name: {fuel.Name}");
            }
        }
        public void GetById(int id)
        {
            Fuel? fuel = fuelRepository.GetById(id);
            if (fuel is null)
            {
                Console.WriteLine($"Aradığınız Id'ye göre araç bulunamadı: {id}");
                return;
            }

            Console.WriteLine($"Fuel ID: {fuel.Id},Fuel Name: {fuel.Name}");
        }
        public void Add(Fuel fuel)
        {
            fuelRepository.Add(fuel);

            Console.WriteLine("Yakıt eklendi : ");
           
        }
        public void Delete(int id)
        {
           Fuel? deletedFuel =fuelRepository.GetById(id);
            if (deletedFuel is null)
            {
                Console.WriteLine("Aradığınız araç bulunamadı (Zaten Yok)");
                return;
            }

           fuelRepository.Delete(id);
            Console.WriteLine($"Silinen Araç: {deletedFuel}");
        }
        public void GetAllDetails()
        {
            List<CarDetailDto> fuels = fuelRepository.GetAllDetails();
            foreach (CarDetailDto fuelDetail in fuels)
            {
                Console.WriteLine(fuelDetail);
            }
        }

    }
}

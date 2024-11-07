

using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;
using static System.Reflection.Metadata.BlobBuilder;

namespace RentACarSimulation.Repository
{
  
    public class CarRepository : IRepository<Car>
    {
     

       List<Car> cars = new List<Car>()
        {
            new Car(1,1,1,1,"Available",15000,2021,"34ABC123","Toyota","Corolla",300.50),
            new Car(1,2,2,1,"Available",5000,2022,"34GHI789","BMW","320i",450.00),
              new Car(3,1,2,1,"Available",5000,2022,"34GHI789","BMW","320i",450.00),

        };
      
        public IEnumerable<Car> GetAll()
        {
            return cars;
        }
        public Car? GetById(int id)
        {
            foreach (Car car in cars)
            {
                if (car.Id == id)
                {
                    return car; 
                }
            }
            return null; 
        }
        public void Add(Car car) 
        {
            cars.Add(car);
        }

        public void Delete(int id)
        {
            Car? deletedCar = GetById(id);
            if (deletedCar is null)
            {
                Console.WriteLine("Aradığınız araç bulunamadı (Zaten yok).");
                return;
            }

            cars.Remove(deletedCar);
            Console.WriteLine($"Araç silindi: {deletedCar.Id}");
        }
        public void Update(Car updatedCar)
        {
            
          
        }
        private TransmissionRepository transmissionRepository = new TransmissionRepository();
        private ColorRepository colorRepository = new ColorRepository(); 
        private FuelRepository fuelRepository = new FuelRepository();
        public List<CarDetailDto> GetAllDetails()
        {
            var transmissions = transmissionRepository.GetAll().ToList();
            var colors = colorRepository.GetAll().ToList();
            var fuels = fuelRepository.GetAll().ToList();

            var result =
        from car in cars
        join color in colors on car.ColorId equals color.Id
        join fuel in fuels on car.FuelId equals fuel.Id
        join transmission in transmissions on car.TransMissionId equals transmission.Id
        select new CarDetailDto(
            id: car.Id,
            fuelName: fuel.Name,
            transmissionName: transmission.Name,
            colorName: color.Name,
            carState: car.CarState,
            kiloMeter: car.KiloMeter,
            modelYear: car.ModelYear,
            plate: car.Plate,
            brandName: car.BrandName,
            modelName: car.ModelName,
            dailyPrice: car.DailyPrice
        );
            return result.ToList();
        }
    }
}

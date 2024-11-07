
using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;
using RentACarSimulation.Repository;
using System.Reflection;


namespace RentACarSimulation.Service
{
    public class CarService
    {
        private IRepository<Car> carRepository = new CarRepository();

        public void GetAll()
        {
            var cars = carRepository.GetAll();

           
            foreach (var car in cars)
            {
                Console.WriteLine( $"Car ID: {car.Id},Color ID: {car.ColorId}, Fuel ID: {car.FuelId}, Transmission ID: {car.TransMissionId}, CarState: {car.CarState}, KiloMeter: {car.KiloMeter}, Year: {car.ModelYear}, Plate: {car.Plate}, BrandName: {car.BrandName}, ModelName: {car.ModelName}, Daily Price: {car.DailyPrice}");
            }
        }
     

        public void GetById(int id)
        {
            Car? car = carRepository.GetById(id); 
            if (car is null)
            {
                Console.WriteLine($"Aradığınız Id'ye göre araç bulunamadı: {id}");
                return;
            }

            Console.WriteLine($"Araç bulundu:Car ID: {car.Id},Color ID: {car.ColorId}, Fuel ID: {car.FuelId}, Transmission ID: {car.TransMissionId}, CarState: {car.CarState}, KiloMeter: {car.KiloMeter}, Year: {car.ModelYear}, Plate: {car.Plate}, BrandName: {car.BrandName}, ModelName: {car.ModelName}, Daily Price: {car.DailyPrice}"); 
        }
      
        public void Add(Car car)
        {
            carRepository.Add(car);

            Console.WriteLine("Araç eklendi ");
           
        }
        public void Delete(int id)
        {
            Car? deletedCar = carRepository.GetById(id);
            if (deletedCar is null)
            {
                Console.WriteLine("Aradığınız araç bulunamadı (Zaten Yok)");
                return;
            }

            carRepository.Delete(id);
            Console.WriteLine($"Silinen Araç: {deletedCar}");
        }

     
        public void GetAllDetails()
        {
            List<CarDetailDto> cars = carRepository.GetAllDetails();
            foreach (CarDetailDto carDetail in cars)
            {
                Console.WriteLine(carDetail);
            }
        }


    }
}

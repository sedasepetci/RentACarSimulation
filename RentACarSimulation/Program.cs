
using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;
using RentACarSimulation.Repository;
using RentACarSimulation.Service;

CarService carService = new CarService();
//carService.GetAll();


//FuelService fuelService = new FuelService();
//fuelService.GetAll();


//TransmissionService transmissionService = new TransmissionService();
//transmissionService.GetAll();

//ColorService colorService = new ColorService();
//colorService.GetAll();

//var carService = new CarService();

//carService.GetById(1); 
//carService.GetById(3); 

//var colorService = new ColorService();

//colorService.GetById(1);
//colorService.GetById(3); 

//var fuelService = new FuelService();

//fuelService.GetById(1);

//var transmissionService = new TransmissionService();

//transmissionService.GetById(1);

// Yeni araba ekleme işlemi
//var newCar = new Car(3, 3, 3, 1, "Available", 10000, 2023, "34JKL456", "Audi", "A4", 500.00);
//carService.Add(newCar); // Yeni arabayı ekle

//// Güncellenmiş arabaları göster
//Console.WriteLine("\nGüncellenmiş Arabalar:");
//carService.GetAll();

var carRepository = new CarRepository();

//// Silinecek aracın ID'sini belirt
//carRepository.Delete(2); // ID'si 3 olan aracı silmeye çalış

//// Kalan araçları kontrol et
//var remainingCars = carRepository.GetAll();
//Console.WriteLine("Kalan Araçlar:");
//foreach (var car in remainingCars)
//{
//    Console.WriteLine($"{car.BrandName} {car.ModelName} - {car.Plate}");

carService.GetAllDetails();
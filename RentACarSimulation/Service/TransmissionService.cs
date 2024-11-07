
using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;
using RentACarSimulation.Repository;

namespace RentACarSimulation.Service
{
    public class TransmissionService
    {
        private IRepository<Transmission> transmissionRepository = new TransmissionRepository();

        public void GetAll()
        {
            var transmissions = transmissionRepository.GetAll();


            foreach (var transmission in transmissions)
            {
                Console.WriteLine($"Transmission ID: {transmission.Id},Transmission Name: {transmission.Name}");
            }
        }
        public void GetById(int id)
        {
            Transmission? transmission = transmissionRepository.GetById(id);
            if (transmission is null)
            {
                Console.WriteLine($"Aradığınız Id'ye göre araç bulunamadı: {id}");
                return;
            }

            Console.WriteLine($"Transmission ID: {transmission.Id},Transmission Name: {transmission.Name}");
        }
        public void Add(Transmission transmission)
        {
            transmissionRepository.Add(transmission);

            Console.WriteLine("Şanzıman eklendi  ");
           
        }
        public void Delete(int id)
        {
            Transmission? deletedTransmission = transmissionRepository.GetById(id);
            if (deletedTransmission is null)
            {
                Console.WriteLine("Aradığınız araç bulunamadı (Zaten Yok)");
                return;
            }

            transmissionRepository.Delete(id);
            Console.WriteLine($"Silinen Araç: {deletedTransmission}");
        }
        public void GetAllDetails()
        {
            List<CarDetailDto> transmissions = transmissionRepository.GetAllDetails();
            foreach (CarDetailDto transmissionDetail in transmissions)
            {
                Console.WriteLine(transmissionDetail);
            }
        }
    }
}

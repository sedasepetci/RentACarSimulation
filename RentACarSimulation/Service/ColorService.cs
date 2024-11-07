

using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;
using RentACarSimulation.Repository;

namespace RentACarSimulation.Service
{
    public class ColorService
    {
        private IRepository<Color> colorRepository = new ColorRepository();

        public void GetAll()
        {
            var colors = colorRepository.GetAll();


            foreach (var color in colors)
            {
                Console.WriteLine($"Color ID: {color.Id},Color Name: {color.Name}");
            }
        }
        public void GetById(int id)
        {
            Color? color = colorRepository.GetById(id);
            if (color is null)
            {
                Console.WriteLine($"Aradığınız Id'ye göre araç bulunamadı: {id}");
                return;
            }

            Console.WriteLine($"Color ID: {color.Id},Color Name: {color.Name}");
        }
        public void Add(Color color)
        {
            colorRepository.Add(color);

            Console.WriteLine("Renk eklendi : ");
          
        }
        public void Delete(int id)
        {
            Color? deletedColor = colorRepository.GetById(id);
            if (deletedColor is null)
            {
                Console.WriteLine("Aradığınız araç bulunamadı (Zaten Yok)");
                return;
            }

            colorRepository.Delete(id);
            Console.WriteLine($"Silinen Araç: {deletedColor}");
        }

        public void GetAllDetails()
        {
            List<CarDetailDto> colors = colorRepository.GetAllDetails();
            foreach (CarDetailDto colorDetail in colors)
            {
                Console.WriteLine(colorDetail);
            }
        }
    }
}

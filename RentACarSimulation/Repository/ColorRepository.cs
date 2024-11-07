
using RentACarSimulation.Models;
using RentACarSimulation.Models.Dtos;

namespace RentACarSimulation.Repository
{

 
    public class ColorRepository : IRepository<Color>

    {
       

        List<Color> colors = new List<Color>()
        {
       new Color(1, "Red"),
       new Color(2, "Blue"),
       new Color(3, "Green"),
        };

        public IEnumerable<Color> GetAll()
        {
            return colors;
        }
        public Color? GetById(int id)
        {
            foreach (Color color in colors)
            {
                if (color.Id == id)
                {
                    return color;
                }
            }
            return null;
        }
        public void Add(Color color)
        {
            colors.Add(color);
        }
        public void Delete(int id)
        {
            Color? deletedColor = GetById(id);
            if (deletedColor is null)
            {
                Console.WriteLine("Aradığınız renk bulunamadı (Zaten yok).");
                return;
            }

            colors.Remove(deletedColor);
            Console.WriteLine($"Renk silindi: {deletedColor.Id}");
        }

        public List<CarDetailDto> GetAllDetails()
        {
            throw new NotImplementedException();
        }
    }
}

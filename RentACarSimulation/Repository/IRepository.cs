

using RentACarSimulation.Models.Dtos;

namespace RentACarSimulation.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Add(T t);
        void Delete(int id);
        List<CarDetailDto> GetAllDetails();


    }
}

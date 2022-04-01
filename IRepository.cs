using PetShop.Data.Models;

namespace PetShop.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        //T Get(int id);
        IEnumerable<T> Get();
        void Update(int id, Animal animal);
        void Add(T entity);
        void Delete(int id);

    }
}
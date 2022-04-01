using Microsoft.EntityFrameworkCore;
using PetShop.Data.Models;

namespace PetShop.Data.Repositories
{
    public interface IAnimalRepository : IRepository<Animal>
    {
        void AddComment(string comment);
        IEnumerable<Animal> Get();
        Animal GetAnimals(int animel);
    }
}
using Microsoft.EntityFrameworkCore;
using PetShop.Data.Contexts;
using PetShop.Data.Models;

namespace PetShop.Data.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly PetShopDbContext _context;
 

        public AnimalRepository(PetShopDbContext context)
        {
            _context = context;
        }

        public DbSet<Animal> Addd()
        {
            return _context.Animals;
        }

        public void Add(Animal entity)
        {
            _context.Animals!.Add(entity);
            _context.SaveChanges();
        }

        public void AddComment(string comment)
        {

        }

        public void Delete(int id)
        {
            var animal = _context.Animals!.Single(a => a.AnimalId == id);
            _context.Animals!.Remove(animal);
            _context.SaveChanges();
        }

       //public Animal Get(int id)
       //{
       //    Animal animal = new Animal();
       //    return animal;
       //}

        public void Update(int id, Animal animal)
        {
            var animalId = _context.Animals!.Single(a => a.AnimalId == id);
            _context.SaveChanges();
        }

        public IEnumerable<Animal> Get() => _context.Animals;

        public Animal GetAnimals(int id)
        {
            return _context.Animals!.Single(c => c.AnimalId == id);
        }

        //IEnumerable<Animal> Get()
        //{
        //    return _context.Animals;
        //}
    }
}

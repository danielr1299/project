using PetShop.Data.Contexts;
using PetShop.Data.Models;

namespace PetShop.Data.Repositories
{
    public class CatgoryRepository : IRepository<Category>
    {
        private readonly PetShopDbContext _context;

        public CatgoryRepository(PetShopDbContext context)
        {
            _context = context;
        }
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> Get()
        {
            return _context.Categories;
        }

        public void Update(int id, Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}

using API.W.Movies.DAL;
using API.W.Movies.DAL.Models;
using API.W.Movies.Repository.IRepository;

namespace API.W.Movies.Repository
{        
    public class CategoryRepository : ICategoryRepository
    {

        private readonly ApplicationDbContext _context;


        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<bool> CategoryExistsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CategoryExistsByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Category>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}

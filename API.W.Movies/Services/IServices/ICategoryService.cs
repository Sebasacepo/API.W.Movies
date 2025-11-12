using API.W.Movies.DAL.Models;

namespace API.W.Movies.Services.IServices
{
    public interface ICategoryService
    {
        Task<ICollection<Category>> GetCategoriesAsync(); //Me retorna una lista de categorías
        Task<Category> GetCategoryAsync(int id); //Me retorna una categoría por su Id
        Task<bool> CategoryExistsByIdAsync(int id); //Me dice si una categoría existe por su Id
        Task<bool> CategoryExistsByNameAsync(string name); //Me dice si una categoría existe por su Id
        Task<bool> CreateCategoryAsync(Category category); //Me crea una categoría
        Task<bool> UpdateCategoryAsync(Category category); //Me actualiza una categoría
        Task<bool> DeleteCategoryAsync(int id); //Me elimina una categoría


    }
}

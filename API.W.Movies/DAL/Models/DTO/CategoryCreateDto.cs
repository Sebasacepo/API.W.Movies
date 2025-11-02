using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models.DTO
{
    public class CategoryCreateDto
    {
        [Required(ErrorMessage ="El nombre de categoría es obligatorio")]
        [MaxLength(100, ErrorMessage ="El número máximo de caracteres es 100")]


        public string Name { get; set; }

    }
}

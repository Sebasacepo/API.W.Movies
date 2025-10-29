using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class Category:AuditBase
    {
        [Required] //Este data annotation está indicando que este campo es obligatorio
        [Display(Name = "Nombre de la categoría")]
        public string Name { get; set; }
    }
}

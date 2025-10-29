using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class AuditBase
    {
       
         [Key] //decorator
         public int Id { get; set; }
         public DateTime CreateDate { get; set; }

         public DateTime ModifiedDate { get; set; }
        
    }
}

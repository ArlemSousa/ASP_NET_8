using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Departments
    {

        [Key] public int DepartmentId { get; set; }

        public string? Name { get; set; }

        public ICollection<Seller>? sellers { get; set; }



    }
}

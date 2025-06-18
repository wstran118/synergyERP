using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SynergyERP.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }
        public ICollection<Employee> employees { get; set;}

    }
}
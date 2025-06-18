using System;
using System.ComponentModel.DataAnnotations;

namespace SynergyERP.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string fullName { get; set; }
        public string email { get; set; }
        public DateTime hireDate { get; set; }
        public int departmentID { get; set; }
        public Department deparment { get; set; }

    }
}
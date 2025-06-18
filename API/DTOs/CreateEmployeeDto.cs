using System;

namespace SynergyERP.DTOs
{
    public class CreateEmployeeDto
    {
        public string fullName { get; set; }
        public string email { get; set; }
        public int departmentId { get; set; }
        public DateTime hireDate { get; set; }
    }
}

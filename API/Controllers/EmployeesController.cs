using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SynergyERP.Data;
using SynergyERP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SynergyERP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeesController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees() => await _context.Employees.Include(e => e.Department).ToListAsync();

        [HttpPost]
        public async Task<ActionResult<EmployeesController>> AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEmployees), new { id = employee.Id }, employee);
        }

    }
}
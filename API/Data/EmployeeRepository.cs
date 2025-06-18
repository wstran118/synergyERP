using Microsoft.EntityFrameworkCore;
using SynergyERP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SynergyERP.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context) => _context = context;

        public async Task<IEnumerable<Employee>> GetAllAsync() =>
            await _context.Employees.Include(e => e.Department).ToListAsync();

        public async Task<Employee> GetByIdAsync(int id) =>
            await _context.Employees.Include(e => e.Department).FirstOrDefaultAsync(e => e.Id == id);

        public async Task AddAsync(Employee employee) =>
            await _context.Employees.AddAsync(employee);

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}

using SynergyERP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SynergyERP.Data
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task SaveChangesAsync();
    }
}

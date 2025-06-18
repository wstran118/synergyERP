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
    public class ExpensesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ExpensesController(AppDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Expense>> Get() => await _context.Expenses.ToListAsync();

        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
            return Ok(expense);
        }
    }
}
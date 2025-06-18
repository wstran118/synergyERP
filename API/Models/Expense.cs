using System;
using System.ComponentModel.DataAnnotations;

namespace SynergyERP.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string description { get; set; }
        public DateTime expenseDate { get; set; }
        public decimal amount { get; set; }
    }
}
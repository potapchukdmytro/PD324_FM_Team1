using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancingManager.Entities;

namespace FinancingManager.Models
{
    public class CostModel
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public required string Name { get; set; }
        public required string Currency { get; set; }
        public required string CostType { get; set; }
    }
}

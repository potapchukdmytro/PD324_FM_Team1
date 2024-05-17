using FinancingManager.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinancingManager.Repositories
{
    public class CostRepository
    {
        private readonly AppDbContext context;

        public CostRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddCost(CostEntity cost)
        {
            context.Costs.Add(cost);
            context.SaveChanges();
        }

        public void UpdateCost(CostEntity cost)
        {
            context.Costs.Update(cost);
            context.SaveChanges();
        }

        public void DeleteCost(int id)
        {
            var cost = context.Costs.Find(id);
            if (cost != null)
            {
                context.Costs.Remove(cost);
                context.SaveChanges();
            }
        }
        public CostEntity GetCostById(int id)
        {
            return context.Costs.Find(id);
        }
        public IEnumerable<CostEntity> GetAllCosts()
        {
            return context.Costs.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using FinancingManager.Entities;
using FinancingManager.Models;
using FinancingManager.Repositories;


namespace FinancingManager.Services
{
    public class CostService
    {
        private readonly CostRepository costRepository;

        public CostService(CostRepository costRepository)
        {
            this.costRepository = costRepository;
        }

        public void AddCost(CostModel cost)
        {
            var costEntity = new CostEntity
            {
                Name = cost.Name,
                Currency = cost.Currency,
                Cost = cost.Cost,
                CostType = cost.CostType
            };
            costRepository.AddCost(costEntity);
            
        }
        public void UpdateCost(CostModel cost) 
        {
            var costEntity = costRepository.GetCostById(cost.Id);
            if (costEntity != null)
            {
                costEntity.Name = cost.Name;
                costEntity.Currency = cost.Currency;
                costEntity.Cost = cost.Cost;
                costRepository.UpdateCost(costEntity);
            }
        }
        public void DeleteCost(int id)
        {
            costRepository.DeleteCost(id);
        }

        public CostModel GetCostById(int id)
        {
            var costEntity = costRepository.GetCostById(id);
            if (costEntity != null)
            {
                return new CostModel
                {
                    Id = costEntity.Id,
                    Name = costEntity.Name,
                    Currency = costEntity.Currency,
                    Cost = costEntity.Cost,
                    CostType = costEntity.CostType
                };
            }
            return null;
        }
        public IEnumerable<CostModel> GetAllCosts()
        {
            var costEntities = costRepository.GetAllCosts();
            return costEntities.Select(c => new CostModel
            {
                Id = c.Id,
                Name = c.Name,
                Currency = c.Currency,
                Cost = c.Cost,
                CostType = c.CostType
            });
        }
    }
}

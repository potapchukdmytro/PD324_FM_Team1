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
                CostType = cost.CostType,
                UserId = 1
            };
            costRepository.Add(costEntity);
            
        }
        public async void UpdateCost(CostModel cost) 
        {
            var costEntity = await costRepository.GetById(cost.Id);
            if (costEntity != null)
            {
                costEntity.Name = cost.Name;
                costEntity.Currency = cost.Currency;
                costEntity.Cost = cost.Cost;
                await costRepository.UpdateAsync(costEntity);
            }
        }
        public async void DeleteCost(int id)
        {
            await costRepository.RemoveAsync(id);
        }

        public async Task<CostModel?> GetCostById(int id)
        {
            var costEntity = await costRepository.GetById(id);
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
            var costEntities = costRepository.GetAll();
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

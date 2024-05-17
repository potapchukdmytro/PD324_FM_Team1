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
    }
}

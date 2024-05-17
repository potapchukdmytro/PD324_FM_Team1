using FinancingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancingManager.Repositories
{
    public class CostRepository
    {
        private readonly AppDbContext context;

        public CostRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(CostEntity entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public async Task AddAsync(CostEntity entity)
        {
            context.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task<CostEntity?> GetById(int id)
        {
            return await context.Costs.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var entity = await GetById(id);

            if (entity != null)
            {
                await RemoveAsync(entity);
            }
        }

        public async Task RemoveAsync(CostEntity entity)
        {
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CostEntity entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }

        public IQueryable<CostEntity> GetAll()
        {
            return context.Costs.AsNoTracking().Include(c => c.User);
        }
    }
}

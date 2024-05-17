using FinancingManager.Entities;

namespace FinancingManager.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool Add(UserEntity entity)
        {
            context.Users.Add(entity);
            return context.SaveChanges() != 0;
        }

        public bool Update(UserEntity entity)
        {
            context.Users.Update(entity);
            return context.SaveChanges() != 0;
        }

        public bool Delete(UserEntity entity)
        {
            context.Remove(entity);
            return context.SaveChanges() != 0;
        }
        public IEnumerable<UserEntity> GetAll()
        {
            return context.Users.ToList();
        }

        public UserEntity? GetById(int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}

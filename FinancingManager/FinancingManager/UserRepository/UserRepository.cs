using FinancingManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancingManager.UserRepository
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

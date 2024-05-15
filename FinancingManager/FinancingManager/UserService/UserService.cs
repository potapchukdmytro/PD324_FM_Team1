using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancingManager.UserService
{
    public class UserService
    {
        private readonly UserRepository.UserRepository userRepository;

        public UserService(UserRepository.UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool Login(string userName, string password)
        {
            var user = userRepository.GetAll().FirstOrDefault(user => user.UserName == userName);
            if (user == null)
            {
                return false;
            }
            if (user.Password == password) 
            {
                return true;
            }
            return false;
        }
    }
}

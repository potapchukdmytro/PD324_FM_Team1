using FinancingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancingManager.Service
{
    public class UserService
    {
        private readonly UserRepository.UserRepository userRepository; 

        public UserService(UserRepository.UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Login(LoginModel loginModel)
        {
            var user = userRepository.GetAll().FirstOrDefault(u => u.UserName == loginModel.Login);

            if (user == null)
            {
                Console.WriteLine("Login failed: User not found.");
                return;
            }

            if (user.Password != loginModel.Password)
            {
                Console.WriteLine("Login failed: Incorrect password.");
                return;
            }

            Console.WriteLine("Login successful!");
        }
    }
}

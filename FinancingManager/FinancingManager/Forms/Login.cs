using FinancingManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancingManager.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            LoginModel model = new LoginModel
            {
                Login = nicknameTextBox.ToString(),
                Password = passwordTextBox.ToString()
            };
            // Далі не знаю куди це передавати тому: {
            MessageBox.Show("User authorized successfully");
            this.Close();
            // }
        }
    }
}

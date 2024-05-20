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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void rejectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void acceptButton_Click(object sender, EventArgs e)
        {
            RegisterModel model = new RegisterModel {
                FirstName = firstNameTextBox.ToString(),
                LastName = lastNameTextBox.ToString(),
                UserName = nicknameTextBox.ToString(),
                Password = passwordTextBox.ToString(),
                Email = mailTextBox.ToString()
            };
            // Далі не знаю куди це передавати тому: {
            MessageBox.Show("User added successfully");
            // }
        }


    }
}

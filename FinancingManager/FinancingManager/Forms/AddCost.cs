using FinancingManager.Models;
using FinancingManager.Services;
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
    public partial class AddCost : Form
    {
        private readonly CostService costService;
        public AddCost(CostService costService)
        {
            InitializeComponent();
            this.costService = costService;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CostModel model = new CostModel
            {
                Cost = double.Parse(textBoxCost.Text),
                CostType = textBoxType.Text,
                Name = textBoxName.Text,
                Currency = textBoxCurrency.Text,
            };

            costService.AddCost(model);
            this.Close();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

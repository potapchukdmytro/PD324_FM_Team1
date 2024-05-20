using FinancingManager.Forms;
using FinancingManager.Repositories;
using FinancingManager.Services;

namespace FinancingManager
{
    public partial class Form1 : Form
    {
        private readonly CostService costService;

        public Form1()
        {
            InitializeComponent();
            AppDbContext context = new AppDbContext();
            CostRepository costRepository = new CostRepository(context);
            costService = new CostService(costRepository);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = costService.GetAllCosts().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCost addCost = new AddCost(costService);
            addCost.ShowDialog();

            dataGridView1.DataSource = costService.GetAllCosts().ToList();

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login reg = new Login();
            reg.ShowDialog();
        }
    }
}

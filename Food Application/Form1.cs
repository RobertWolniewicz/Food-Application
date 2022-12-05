global using Food_Application.Entity;
global using System;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.Data;
global using System.Drawing;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;
global using System.Windows.Forms;

namespace Food_Application
{
    public partial class Form1 : Form
    {
        private readonly ApplicatioDbContext _dbContext;

        public Form1()
        {
            InitializeComponent();
            var optionBuilder= new DbContextOptionsBuilder<ApplicatioDbContext>()
                .UseSqlite(@"Data Source=C:\Users\User\Desktop\Programy\Food Application\DB\FoodCalculatorDB.db");
            var dbContext = new ApplicatioDbContext(optionBuilder.Options);
            _dbContext = dbContext;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var form = new Form4(_dbContext);
            await Task.Run(() => form.ShowDialog());
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var form= new Form2(_dbContext);
            await Task.Run(() => form.ShowDialog());

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var form = new Form5(_dbContext);
            await Task.Run(() => form.ShowDialog());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

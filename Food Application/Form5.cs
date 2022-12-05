using Food_Application.DishOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Application
{
    public partial class Form5 : Form
    {
        public ApplicatioDbContext DbContext { get; set; }
        public Form5(ApplicatioDbContext dbContext)
        {
            DbContext = dbContext;
            InitializeComponent();
            var Dishes = dbContext.Dishs;
            foreach (var dish in Dishes)
            {
                listBox1.Items.Add(dish);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            var i = listBox1.SelectedIndex;
            if (i == -1)
            {
                label1.Text = "Nie zaznaczono żadnego składnika";
            }
            else
            {
                var selectedDish = await DbContext.Dishs.FirstAsync(d => d.name == listBox1.SelectedItem.ToString());
                var form = new Form3(DbContext, selectedDish);
                await Task.Run(() => form.ShowDialog());
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            var form = new Form3(DbContext);
            await Task.Run(() => form.ShowDialog());
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            var i = listBox1.SelectedIndex;
            if (i == -1)
            {
                label1.Text = "Nie zaznaczono żadnego składnika";
            }
            else
            {
                var deletingDish = listBox1.SelectedItem.ToString();
               await Deleter.Delet(DbContext, deletingDish);
                listBox1.SelectedIndex--;
                listBox1.Items.RemoveAt(i);
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (FindBox.Text.Length == 0)
            {
                listBox1.Items.Clear();
                var Dishes = DbContext.Dishs;
                foreach (var Dish in Dishes)
                {
                    listBox1.Items.Add(Dish.ToString());
                }
            }
            else
            {
                var searchingPhrase = FindBox.Text;
                var result = await dishFinder.Find(DbContext, searchingPhrase);
                listBox1.Items.Clear();
                foreach (var Dish in result)
                {
                    listBox1.Items.Add(Dish.ToString());
                }
            }
        }
    }
}

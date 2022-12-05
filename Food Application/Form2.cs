namespace Food_Application
{
    public partial class Form2 : Form
    {
        public ApplicatioDbContext DbContext { get; }
        public Form2(ApplicatioDbContext dbContext)
        {
            InitializeComponent();
            DbContext = dbContext;
            var Ingridiens = dbContext.ingridiens;
            foreach (var ingridien in Ingridiens)
            { 
             listBox2.Items.Add(ingridien.ToString());
            }
            
        }
        public void Clean()
        {
            NameBox.Text = "";
            MasBox.Text = "";
            PriceBox.Text = "";
            QuantityBox.Text = "";
        }
        public void InfoLabelClean()
        {
            Infolabel.Text = "";
            Infolabel.BackColor = Color.White;
        }
        private  async void button3_Click(object sender, EventArgs e)
        {
            InfoLabelClean();
            Form2 form2 = this;
            var adder = new Add(form2, DbContext);
            var resultData =await adder.ValidationData();
            var resultNew = await adder.ValidationNew();
            var resultParse = await adder.ValidationParse();
            if (resultData&&resultNew&&resultParse)
            {
                adder.Adding();
                Clean();
            }
            
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            InfoLabelClean();
            var i = listBox2.SelectedIndex;
            if (i == -1)
            {
                Infolabel.Text = "Nie wybrano składnika";
                Infolabel.BackColor = Color.Red;
                await Task.Delay(2000);
                InfoLabelClean();
            }
            else
            {
                var updatingIngridien = await DbContext.ingridiens.FirstAsync(i => i.name == listBox2.SelectedItem);
            Form2 form2 = this;
            var adder = new Add(form2, DbContext);
            var resultData = await adder.ValidationData();
            var resultParse = await adder.ValidationParse();
                if (resultData && resultParse)
                {
                    var updatedIngridien = await update.addData(updatingIngridien, form2);
                    await DbContext.SaveChangesAsync();
                    listBox2.SelectedIndexChanged -= new EventHandler(listBox2_SelectedIndexChanged);
                    listBox2.Items[listBox2.SelectedIndex] = updatingIngridien.name.ToString();
                    listBox2.SelectedIndexChanged += new EventHandler(listBox2_SelectedIndexChanged);
                    Clean();
                    listBox2.SelectedIndex = -1;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            InfoLabelClean();
            var i = listBox2.SelectedIndex;
            if (i == -1)
            {
                Infolabel.Text = "Nie wybrano składnika";
                Infolabel.BackColor = Color.Red;
                await Task.Delay(1000);
                InfoLabelClean();
            }
            else
            {
                var deletenIngridien = listBox2.SelectedItem.ToString();
                await Delete.Deleter(DbContext, deletenIngridien);
                listBox2.SelectedIndex--;
                listBox2.Items.RemoveAt(i);
            }
        }

        private async void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Infolabel.Text = "";
            if (listBox2.SelectedIndex == -1)
            {
                Clean();
            }
            else
            {
                var selectIngridien = await DbContext.ingridiens.FirstOrDefaultAsync(i => i.name == listBox2.SelectedItem.ToString());
                NameBox.Text = selectIngridien.name;
                PriceBox.Text = selectIngridien.price.ToString();
                MasBox.Text = selectIngridien.mas.ToString();
                QuantityBox.Text = selectIngridien.quantity.ToString();
            }
        }
        private async void FindBox_TextChanged(object sender, EventArgs e)
        {
            Infolabel.Text = "";
            if (FindBox.Text.Length == 0)
            {
                listBox2.Items.Clear();
                var Ingridiens = DbContext.ingridiens;
                foreach (var ingridien in Ingridiens)
                {
                    listBox2.Items.Add(ingridien.ToString());
                }
            }
            else
            {
                var searchingPhrase = FindBox.Text;
                var result = await Finder.Find(DbContext, searchingPhrase);
                listBox2.Items.Clear();
                foreach (var ingridien in result)
                {
                    listBox2.Items.Add(ingridien.ToString());
                }
            }
        }
    }
}

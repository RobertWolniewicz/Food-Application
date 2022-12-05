global using Food_Application.DishOptions;

namespace Food_Application;

public partial class Form3 : Form
{
    public string? _updatingDish { get; set; }
    public ApplicatioDbContext DbContext { get; }
    public List<DishIngridien> ingridienList = new List<DishIngridien>();
    public Form3(ApplicatioDbContext dbContext)
    {
        InitializeComponent();
        DbContext = dbContext;
        var ingridiens = dbContext.ingridiens;
        foreach (var ingridien in ingridiens)
        {
          listBox2.Items.Add(ingridien);
        }
    }
    public Form3(ApplicatioDbContext dbContext, Dish updatingDish) : this (dbContext)
    {
        _updatingDish = updatingDish.name;
        textBox1.Text = updatingDish.name;
        textBox2.Text = updatingDish.portions.ToString();
        var dishIngridiens = dbContext.dishIngridiens.Where(dI => dI.DishId == updatingDish.id);
        foreach (var ingridien in dishIngridiens)
        {
            listBox1.Items.Add(ingridien.name);
            ingridienList.Add(ingridien);
        }
        this.button4.Text = "Zapisz";
        this.button4.Click -= new System.EventHandler(this.button4_Click);
        this.button4.Click += new System.EventHandler(this.button4_Click2);
    }
    public void Clean()
    {
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
        textBox4.Text = "";
    }
    private async void button1_Click(object sender, EventArgs e)
    {
        label6.Text = "";
        var i = listBox2.SelectedIndex;
        if (i == -1)
        {
            label6.Text = "Nie zaznaczono żadnego składnika";
        }
        else
        {
            var goodQuantity = double.TryParse(textBox4.Text, out double quantity);
            var goodMas = double.TryParse(textBox3.Text, out double mas);
            if (!goodMas && !goodQuantity)
            {
                label6.Text = "Błędne wartości";
            }
            else
            {
                var newIngridien = new DishIngridien()
                {
                    name = listBox2.SelectedItem.ToString()
                };
                if (textBox3.Text.Length == 0)
                {
                    newIngridien.quantity = quantity;
                }
                else
                {
                    newIngridien.mas = mas;
                }
                ingridienList.Add(newIngridien);
                listBox1.Items.Add(newIngridien.name);
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        label6.Text = "";
        var i = listBox1.SelectedIndex;
        if (i == -1)
        {
            label6.Text = "Nie zaznaczono żadnego składnika";
        }
        else
        {
            ingridienList.RemoveAt(i);
            listBox1.SelectedIndex--;
            listBox1.Items.RemoveAt(i);
        }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        label6.Text = "";
        if (listBox1.SelectedIndex == -1)
        {
            textBox3.Text = null;
            textBox4.Text = null;
        }
        else
        {
            var selectIngridien =  ingridienList.First(i => i.name == listBox1.SelectedItem.ToString());
            textBox3.Text = selectIngridien.mas.ToString();
            textBox4.Text = selectIngridien.quantity.ToString();
        }
    }

    private  void button2_Click(object sender, EventArgs e)
    {
        label6.Text = "";
        var i = listBox1.SelectedIndex;
        if (i == -1)
        {
            label6.Text = "Nie zaznaczono żadnego składnika";
        }
        else
        {
            var goodQuantity = double.TryParse(textBox4.Text, out double quantity);
            var goodMas = double.TryParse(textBox3.Text, out double mas);
            if (!goodMas && !goodQuantity)
            {
                label6.Text = "Błędne wartości";
            }
            else
            {
                var selectIngridien = ingridienList.First(i => i.name == listBox1.SelectedItem.ToString());
                if (textBox3.Text.Length == 0)
                {
                    selectIngridien.quantity = double.Parse(textBox4.Text);
                }
                else
                {
                    selectIngridien.mas = double.Parse(textBox3.Text);
                }
            }

        }
    }

    private async void button4_Click(object sender, EventArgs e)
    {
        label6.Text = "";
        var goodPortions = int.TryParse(textBox2.Text, out int portions);
        if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || ingridienList.Count == 0 || goodPortions || portions<=0)
        {
            label6.Text = "Złe dane potrawy";
        }
        else
        {
            if (DbContext.Dishs.Any(i => i.name == textBox1.Text))
            {
                label6.Text = "Ta potrawa juz istnieje";
            }
            else
            {
                Form3 form = this;
                await Adder.add(form, DbContext, portions);
                ingridienList.Clear();
                listBox1.Items.Clear();
                Clean();
            }
        }
}

    private async void button5_Click(object sender, EventArgs e)
    {
        label6.Text = "";
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
    private void button4_Click2(object sender, EventArgs e)
    {
        Form3 form = this;
        Updater.Update(form, DbContext, _updatingDish);
        ingridienList.Clear();
        listBox1.Items.Clear();
        Clean();
    }
}
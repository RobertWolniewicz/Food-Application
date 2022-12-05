namespace Food_Application;

public partial class Form4 : Form
{
    public int goodGuests = 0;
    public int goodprice = 0;
    public List<Dish> dishList = new List<Dish>();
    public ApplicatioDbContext DbContext { get; }
    public Form4(ApplicatioDbContext dbContext)
    {
        InitializeComponent();
        DbContext = dbContext;
        var Dishes = dbContext.Dishs;
        foreach (var Dish in Dishes)
        {
            listBox1.Items.Add(Dish.ToString());
        }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        var i = listBox1.SelectedIndex;
        if (i == -1)
        {
            label1.Text = "Nie zaznaczono żadnego składnika";
        }
        else
        {
            var menuDish = await DbContext.Dishs.FirstAsync(D => D.name == listBox1.SelectedItem.ToString());
            listBox2.Items.Add(menuDish.ToString());
            dishList.Add(menuDish);
            Count();
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var i = listBox1.SelectedIndex;
        if (i == -1)
        {
            Infolabel.Text = "Nie zaznaczono żadnego składnika";
        }
        else
        {
            var deletingDish = dishList.First(D => D.name == listBox1.SelectedItem.ToString());
            dishList.Remove(deletingDish);
            listBox1.SelectedIndex--;
            listBox1.Items.RemoveAt(i);
        }
    }
    public async void Count()
    {
        double totalPrice = 0;
        if ((listBox2.Items.Count != 0) && (goodprice == 1) && (goodGuests == 1))
        {
            foreach (var dish in dishList)
            {
                var dishIngridiens = DbContext.dishIngridiens.Where(dI => dI.DishId == dish.id);
                double price = 0;
                foreach (var ingridien in dishIngridiens)
                {
                    var dbIngridien = await DbContext.ingridiens.FirstAsync(I => I.name == ingridien.name);
                    if (dbIngridien.mas == null)
                    {
                        price += (double)((ingridien.quantity / dbIngridien.quantity) * dbIngridien.price);
                    }
                    else
                    {
                        price += (double)((ingridien.mas / dbIngridien.mas) * dbIngridien.price);
                    }
                }
                price = price * (double)Math.Ceiling((decimal)(int.Parse(textBox1.Text) / dish.portions));
                totalPrice += price;
            }
            totalPrice = totalPrice * (1 + (double.Parse(textBox2.Text) / 100));
            label8.Text = totalPrice.ToString("F");
            label7.Text = (totalPrice / int.Parse(textBox1.Text)).ToString("F");
        }
        else
        {
            label8.Text = "0";
            label7.Text = "0";
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        var goodValue = double.TryParse(textBox1.Text, out double guests);
        if (goodValue)
        {
            goodGuests = 1;
            Count();
        }
        else
        {
            goodGuests = 0;
            label8.Text = "Złe wartości";
            label7.Text = "Złe wartości";
        }

}
    private void textBox2_TextChanged(object sender, EventArgs e)
    {
        var goodValue = double.TryParse(textBox2.Text, out double guests);
        if (goodValue)
        {
            goodprice = 1;
            Count();
        }
        else
        {
            goodprice = 0;
            label8.Text = "Złe wartości";
            label7.Text = "Złe wartości";
        }
    } 
}
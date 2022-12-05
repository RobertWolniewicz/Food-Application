global using Food_Application.Entity;

namespace Food_Application;

public  class Add
{
    public Form2 form;
    public ApplicatioDbContext DbContext;


    public Add(Form2 form2, ApplicatioDbContext dbContext)
    {
        this.form = form2;
        DbContext = dbContext;
    }

    public async Task<bool> ValidationData()
    {
        
        if (((form.NameBox.Text.Length == 0) || (form.PriceBox.Text.Length == 0)) ||
               (((form.MasBox.Text.Length == 0) && (form.QuantityBox.Text.Length == 0))))
        {
            form.Infolabel.Text = "Błędne dane";
            return false;
        }
        else return true;
    }
    public async Task<bool> ValidationNew()
    {
        if (DbContext.ingridiens.Any(i => i.name.ToLower() == form.NameBox.Text.ToLower()))
        {
            form.Infolabel.Text = "Ten składnik juz istnieje";
            return false;
        }
        else return true;
    }
    public  async Task<bool> ValidationParse()
    {
        var goodValue = Double.TryParse(form.QuantityBox.Text, out Double quantityResult) ||
         Double.TryParse(form.MasBox.Text, out Double masResult) &&
         Double.TryParse(form.PriceBox.Text, out Double priceResult);
        if (!goodValue)
        {
            form.Infolabel.Text = "Błędne wartości";
            return false;
        }
        else return true;
    }
    public async void Adding()
    {
        var newIngridien = new Ingridien();
        var _newIngridien = await update.addData(newIngridien, form);
        await DbContext.ingridiens.AddAsync(_newIngridien);
        await DbContext.SaveChangesAsync();
        form.listBox2.Items.Add(_newIngridien.ToString());
    }
}

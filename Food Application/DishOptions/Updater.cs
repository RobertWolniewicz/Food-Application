using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Application.DishOptions;

internal class Updater
{
    public static async void Update(Form3 form, ApplicatioDbContext DbContext, string updatingDish)
    {
        var Dish = await DbContext.Dishs.FirstAsync(D => D.name.ToLower() == updatingDish.ToLower());
            Dish.name = form.textBox1.Text;
            Dish.portions = double.Parse(form.textBox2.Text);
        foreach (var ingridien in form.ingridienList)
        {
            Dish.ingridiens.Add(ingridien);
        }
        await DbContext.SaveChangesAsync();
    }
}
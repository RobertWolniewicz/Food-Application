using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Application.DishOptions
{
    internal class Adder
    {
        public static async Task<Dish> add(Form3 form, ApplicatioDbContext DbContext, int portions)
        {
            var newDish = new Dish()
            {
                name = form.textBox1.Text,
                portions = portions
            };
            foreach (var ingridien in form.ingridienList)
            {
                newDish.ingridiens.Add(ingridien);
            }
            await DbContext.Dishs.AddAsync(newDish);
            await DbContext.SaveChangesAsync();
            return newDish;
        }
    }
}

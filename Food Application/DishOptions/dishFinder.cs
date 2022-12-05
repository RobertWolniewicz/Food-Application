using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Application.DishOptions
{
    internal class dishFinder
    {
        public static async Task<List<Dish>> Find(ApplicatioDbContext dbContext, string searchPhrase)
        {
            var result = await dbContext.Dishs.Where(i => i.name.ToLower().Contains(searchPhrase.ToLower())).ToListAsync();
            return result;
        }
    }
}

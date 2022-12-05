using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Application.Entity
{
    public class DishIngridien
    {
        public int id { get; set; }
        public string name { get; set; }
        public double? mas { get; set; }
        public double? quantity { get; set; }
        public Dish Dish { get; set; }
        public int DishId { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}

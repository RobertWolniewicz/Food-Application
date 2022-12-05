using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Application.Entity;

public class Dish
{
    public int id { get; set; }
    public string name { get; set; }
    public double? price { get; set; }
    public double? portions { get; set; }
    public List<DishIngridien> ingridiens { get; set; } = new List<DishIngridien>();

    public override string ToString()
    {
        return name;
    }
}

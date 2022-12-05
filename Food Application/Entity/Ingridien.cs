using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Application.Entity;

public class Ingridien
{
    public int id { get; set; }
    public string name { get; set; }
    public double price { get; set; }
    public double? mas { get; set; }
    public double? quantity { get; set; }

    public override string ToString()
   {
        return name;
    }
}

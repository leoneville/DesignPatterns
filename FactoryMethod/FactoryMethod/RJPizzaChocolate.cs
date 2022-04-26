using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RJPizzaChocolate : Pizza
    {
        public RJPizzaChocolate()
        {
            Nome = "Pizza de chocolate carioca";
            massa = "Massa fina crocante carioca";
            molho = "Chocolate branco derretido carioca";
            ingredientes.Add("Pedaços de KitKat");
            ingredientes.Add("Chocolate meio amargo ralado");
        }
    }
}

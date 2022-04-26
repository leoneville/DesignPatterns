using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SPPizzaChocolate : Pizza
    {
        public SPPizzaChocolate()
        {
            Nome = "Pizza de chocolate paulista";
            massa = "Massa fina crocante paulista";
            molho = "Chocolate branco derretido paulista";
            ingredientes.Add("Pedaços de KitKat");
            ingredientes.Add("Chocolate meio amargo ralado");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SPPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new SPPizzaMussarela();
            }
            if (tipo.Equals("C"))
            {
                return new SPPizzaChocolate();
            }
            return null;
        }
    }
}

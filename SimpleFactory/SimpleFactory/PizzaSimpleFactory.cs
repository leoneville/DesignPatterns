using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class PizzaSimpleFactory
    {
        public static Pizza CriaPizza(string nomePizza)
        {
            Pizza pizza;

            switch (nomePizza)
            {
                case "C":
                    pizza = new PizzaChocolate();
                    break;
                case "M":
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException($"A pizza {nomePizza} não foi criada!");
            }
            return pizza;
        }
    }
}

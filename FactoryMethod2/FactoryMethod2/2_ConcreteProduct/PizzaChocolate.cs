using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    //Product Concrete
    public class PizzaChocolate : Pizza
    {
        private readonly string _nomePizza;

        public PizzaChocolate()
        {
            _nomePizza = "Pizza Chocolate";
            Ingredientes.Add("Chocolate amargo ralado");
            Ingredientes.Add("Pedaços de KitKat");
        }
        public override string Nome { get => _nomePizza; }
    }
}

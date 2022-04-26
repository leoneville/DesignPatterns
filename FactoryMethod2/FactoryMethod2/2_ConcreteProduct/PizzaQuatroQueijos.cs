using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    //Product Concrete
    public class PizzaQuatroQueijos : Pizza
    {
        private readonly string _nomePizza;
        public PizzaQuatroQueijos()
        {
            _nomePizza = "Pizza Quatro Queijos";
            Ingredientes.Add("Queijo parmesão");
            Ingredientes.Add("Queijo Gorgonzola");
            Ingredientes.Add("Queijo Brie");
            Ingredientes.Add("Queijo Provolone");
        }
        public override string Nome { get => _nomePizza; }
    }
}

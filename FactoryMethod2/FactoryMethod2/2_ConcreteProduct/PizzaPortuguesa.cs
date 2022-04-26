using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    //Product Concrete
    public class PizzaPortuguesa : Pizza
    {
        private readonly string _nomePizza;
        public PizzaPortuguesa()
        {
            _nomePizza = "Pizza Portuguesa";
            Ingredientes.Add("Queijo parmesão");
            Ingredientes.Add("Ervilhas");
            Ingredientes.Add("Cebola");
            Ingredientes.Add("Ovos cozidos");
        }
        public override string Nome { get => _nomePizza; }
    }
}

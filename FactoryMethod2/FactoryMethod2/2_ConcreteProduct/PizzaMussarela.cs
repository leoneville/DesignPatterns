using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    //Product Concrete
    public class PizzaMussarela : Pizza
    {
        private readonly string _nomePizza;
        public PizzaMussarela()
        {
            _nomePizza = "Pizza Mussarela";
            Ingredientes.Add("Queijo parmesão ralado");
            Ingredientes.Add("Molho de tomate e azeitonas");
        }
        public override string Nome { get => _nomePizza; }
    }
}

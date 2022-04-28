using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Domain.Products
{
    public sealed class PizzaChocolate : Pizza
    {
        public PizzaChocolate() : base("Pizza Chocolate", Enums.TipoMassa.Pizza)
        {
            Ingredientes.Add("Cobertura de chocolate Nutella");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    //Creator
    public abstract class PizzaFactoryMethod
    {
        public abstract Pizza CriarPizza(int tipo);
    }
}

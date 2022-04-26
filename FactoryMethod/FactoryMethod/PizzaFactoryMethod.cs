﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontaPizza(string tipo)
        {
            Pizza pizza = CriarPizza(tipo);
            return pizza;
        }
        protected abstract Pizza CriarPizza(string tipo);
    }
}

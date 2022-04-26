using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FactoryMethod2
{
    //Product
    public abstract class Pizza
    {
        public abstract string Nome { get; }
        public ArrayList Ingredientes = new ArrayList();
    }
}

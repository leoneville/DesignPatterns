using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class AppleFactory : CelularFactory
    {
        public override ICelular CriarCelular()
        {
            return new IPhone();
        }
    }
}

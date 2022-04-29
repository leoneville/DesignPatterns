using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Celular3GFactory : ICelularAbstractFactory
    {
        public ICelularApple CriarCelularApple()
        {
            return new IPhone3G();
        }

        public ICelularNokia CriarCelularNokia()
        {
            return new Nokia3G();
        }
    }
}

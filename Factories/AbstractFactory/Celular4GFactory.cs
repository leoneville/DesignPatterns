using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Celular4GFactory : ICelularAbstractFactory
    {
        public ICelularApple CriarCelularApple()
        {
            return new IPhone4G();
        }

        public ICelularNokia CriarCelularNokia()
        {
            return new Nokia4G();
        }
    }
}

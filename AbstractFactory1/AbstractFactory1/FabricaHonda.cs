using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    class FabricaHonda : IMontadora
    {
        public ISedan CriarSedan()
        {
            return new HondaCivic();
        }
        public ISuv CriarSuv()
        {
            return new HondaCRV();
        }
    }
}

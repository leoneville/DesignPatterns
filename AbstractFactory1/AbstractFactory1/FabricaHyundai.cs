using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    class FabricaHyundai : IMontadora
    {
        public ISedan CriarSedan()
        {
            return new HB20Hyundai();
        }
        public ISuv CriarSuv()
        {
            return new CretaHyundai();
        }
    }
}

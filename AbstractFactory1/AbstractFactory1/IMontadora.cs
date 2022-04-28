using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    interface IMontadora
    {
        ISuv CriarSuv();
        ISedan CriarSedan();
    }
}

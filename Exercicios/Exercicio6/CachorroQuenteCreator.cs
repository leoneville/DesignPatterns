using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class CachorroQuenteCreator : LancheCreator
    {
        protected override Lanche CriaLanche()
        {
            return new CachorroQuente();
        }
    }
}

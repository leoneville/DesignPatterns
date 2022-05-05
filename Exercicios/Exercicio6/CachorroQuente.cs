using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class CachorroQuente : Lanche
    {
        public override string GetCondimentos()
        {
            return "Batata Palha, mostarda, maionese e molho de tomate";
        }

        public override string GetPao()
        {
            return "Pão sovado especial";
        }

        public override string GetRecheio()
        {
            return "Duas salsichas cozidas de 50g";
        }
    }
}

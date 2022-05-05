using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class MistoQuente : Lanche
    {
        public override string GetCondimentos()
        {
            return "Pão de forma branco";
        }

        public override string GetPao()
        {
            return "100g de Presunto e 100g de queijo";
        }

        public override string GetRecheio()
        {
            return "50g de Tomate";
        }
    }
}

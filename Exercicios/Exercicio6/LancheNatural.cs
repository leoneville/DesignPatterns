using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class LancheNatural : Lanche
    {
        public override string GetCondimentos()
        {
            return "Azeite, maionese";
        }

        public override string GetPao()
        {
            return "Pão de forma integral";
        }

        public override string GetRecheio()
        {
            return "Alface, tomate, cenoura ralada, rúcula, pepino e cebola";
        }
    }
}

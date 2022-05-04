using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class Ford : IMontadora
    {
        public string Cor => "Branco";

        public string Modelo()
        {
            return "Ford KA 1.0 Turbo 2020";
        }
    }
}

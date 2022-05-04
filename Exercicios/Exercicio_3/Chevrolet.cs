using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class Chevrolet : IMontadora
    {
        public string Cor => "Prata";

        public string Modelo()
        {
            return "Chevrolet Onix Plus 2020";
        }
    }
}

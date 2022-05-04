using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public class Honda : IMontadora
    {
        public string Cor => "Vermelho";

        public string Modelo()
        {
            return "Honda Civic 2020";
        }
    }
}

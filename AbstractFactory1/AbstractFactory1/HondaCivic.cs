using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    class HondaCivic : ISedan
    {
        public string ExibeDetalhes()
        {
            return "Honda Civic 1.5 173 cv\nAno 2020";
        }
    }
}

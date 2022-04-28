using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory1
{
    class HB20Hyundai : ISedan
    {
        public string ExibeDetalhes()
        {
            return "HB20 Hyundai 1.6\nAno 2020";
        }
    }
}

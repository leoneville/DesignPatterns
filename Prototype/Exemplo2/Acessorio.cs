using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    public class Acessorio
    {
        public string Nome { get; set; }

        public Acessorio Clone()
        {
            return (Acessorio)this.MemberwiseClone();
        }
    }
}

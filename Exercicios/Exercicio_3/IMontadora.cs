using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    public interface IMontadora
    {
        public string Cor { get; }
        public string Modelo();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class IPhone : ICelular
    {
        public void Especificacao()
        {
            Console.WriteLine("Celular IPhone");
        }
    }
}

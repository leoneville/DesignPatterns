using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Old_Logger
    {
        private Old_Logger() { }

        public static Old_Logger GetLogger()
        {
            return new Old_Logger();
        }

        public void Registrar(string  mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}

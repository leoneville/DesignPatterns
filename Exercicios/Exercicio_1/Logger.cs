using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();

        private Logger() { }

        public static Logger GetLogger()
        {
            return instance;
        }
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}

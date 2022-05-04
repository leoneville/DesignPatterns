using System;
using System.Collections.Generic;

namespace Exercicio_4
{
    public class Lanche
    {
        private string _tipoLanche;
        private Dictionary<string, string> _ingredientes = new Dictionary<string, string>();

        public Lanche(string tipoLanche)
        {
            _tipoLanche = tipoLanche;
        }

        public string this[string key]
        {
            get { return _ingredientes[key]; }
            set { _ingredientes[key] = value; }
        }

        public void Exibir()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine($"{_tipoLanche}");
            Console.WriteLine($" Pão: {_ingredientes["pao"]}");
            Console.WriteLine($" Recheio: {_ingredientes["recheio"]}");
            Console.WriteLine($" Vegetais: {_ingredientes["vegetais"]}");
            Console.WriteLine($" Condimentos: {_ingredientes["condimentos"]}");
        }
    }
}

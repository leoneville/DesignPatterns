using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Estatico
{
    public sealed class Singleton
    {
        private static int contador = 0;
        private static readonly Singleton instance;

        private Singleton() { }
        
        static Singleton()
        {
            contador++;
            WriteLine($"Instância: {contador}");
            instance = new Singleton();
        }
        
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}

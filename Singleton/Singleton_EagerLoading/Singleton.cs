using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_EagerLoading
{
    public sealed class Singleton
    {
        // eager loading
        private static readonly Singleton instance = new Singleton();
        private static int contador = 0;

        private Singleton()
        {
            contador++;
            WriteLine($"Instancia: {contador}");
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

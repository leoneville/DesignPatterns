using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_ThreadSafety
{
    public class Singleton
    {
        private static int contador = 0;
        private static Singleton instance;
        private static readonly object lockObject = new object();

        private Singleton()
        {
            contador++;
            WriteLine($"Instancia {contador}");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}

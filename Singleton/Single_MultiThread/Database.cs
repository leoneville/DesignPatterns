using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_MultiThread
{
    public class Database
    {
        private static int contador = 0;
        private static Database connect;

        private Database()
        {
            contador++;
            WriteLine($"Instância {contador}");
        }

        public static Database Connect
        {
            get
            {
                if (connect == null)
                {
                    connect = new Database();
                }
                return connect;
            }
        }
    }
}

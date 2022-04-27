using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrenteSingl
{
    public class ContaCorrente
    {
        public string NumeroConta { get; set; }
        private static ContaCorrente instance;

        private ContaCorrente()
        {

        }

        public static ContaCorrente Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContaCorrente();
                }

                return instance;
            }
        }
    }
}

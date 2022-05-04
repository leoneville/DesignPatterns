using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Exemplo1
{
    public sealed class Calcular
    {
        private static Calcular instance;
        private static readonly object padlock = new object();

        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        private Calcular() { }

        public static Calcular Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Calcular();
                        }
                    }
                }
                return instance;
            }
        }

        public double Somar()
        {
            return Valor1 + Valor2;
        }

        public double Subtrair()
        {
            return Valor1 - Valor2;
        }

        public double Multiplicar()
        {
            return Valor1 * Valor2;
        }

        public double Dividir()
        {
            return Valor1 / Valor2;
        }
    }
}

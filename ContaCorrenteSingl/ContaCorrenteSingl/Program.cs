using System;

namespace ContaCorrenteSingl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            criarContas();
        }

        public static void criarContas()
        {
            ContaCorrente ct1 = ContaCorrente.Instance;
            ct1.NumeroConta = "123-45";
            Console.WriteLine($"{ct1} - {ct1.GetHashCode()}");
            ContaCorrente ct2 = ContaCorrente.Instance;
            ct2.NumeroConta = "323-35";
            Console.WriteLine($"{ct2} - {ct2.GetHashCode()}");
        }
    }
}

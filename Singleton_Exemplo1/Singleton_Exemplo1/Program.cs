using static System.Console;

namespace Singleton_Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = Calcular.Instance.Valor1 = 10.5;
            var v2 = Calcular.Instance.Valor2 = 5.5;

            WriteLine($"Valor1 = {v1} Valor2 = {v2}");

            WriteLine("\n----------------------\n");

            WriteLine("Adição: " + Calcular.Instance.Somar());
            WriteLine("Subtração: " + Calcular.Instance.Subtrair());
            WriteLine("Multiplicação: " + Calcular.Instance.Multiplicar());
            WriteLine("Divisão: " + Calcular.Instance.Dividir());

            WriteLine("\n----------------------\n");
        }
    }
}

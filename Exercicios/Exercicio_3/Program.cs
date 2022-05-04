using System;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    IMontadora instancia = null;

                    Console.WriteLine("Selecione a Montadora (para sair digite S)");
                    Console.WriteLine("(C)hevrolet (F)ord (H)onda");
                    string opcao = Console.ReadLine().ToUpper();

                    if (opcao.Equals("S"))
                        break;

                    instancia = MontadoraSimpleFactory.CriaCarro(opcao);

                    Console.WriteLine($"\n{instancia.Modelo()} - {instancia.Cor}\n");
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}

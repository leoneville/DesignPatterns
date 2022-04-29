using System;

namespace Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cria objeto do tipo Soldado
            Soldado soldado = new Soldado();
            soldado.Nome = "Soldado";
            soldado.Arma = "Fuzil";

            Soldado soldado_clone1 = (Soldado)soldado.Clone();
            Soldado soldado_clone2 = (Soldado)soldado.Clone();

            //Atribui valores ao clone1
            soldado_clone1.Nome = "Soldado Clone1";
            soldado_clone1.Arma = "Bazuca";

            //Atribui valores ao clone2
            soldado_clone2.Nome = "Soldado Clone2";
            soldado_clone2.Arma = "Metralhadora";

            //Exibe valores do objeto original
            Console.WriteLine(">> Objeto Original");
            Console.WriteLine($"{soldado.Nome} - {soldado.Arma}\n");

            //Valores de objeto clone1
            Console.WriteLine(">> Objeto Clone1");
            Console.WriteLine($"{soldado_clone1.Nome} - {soldado_clone1.Arma}\n");

            //Valores de objeto clone2
            Console.WriteLine(">> Objeto Clone2");
            Console.WriteLine($"{soldado_clone2.Nome} - {soldado_clone2.Arma}\n");
        }
    }
}

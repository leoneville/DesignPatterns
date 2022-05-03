using static System.Console;

namespace ExercicioPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programador programador = new Programador();
            programador.Nome = "Neville";
            programador.Cargo = "Programador Plêno";
            programador.Linguagem = "C#";

            Programador programadorClone = (Programador)programador.Clone();
            programadorClone.Nome = "Laís";
            programadorClone.Cargo = "Programador Júnior";
            programadorClone.Linguagem = "Python";

            WriteLine(programador);
            WriteLine(programadorClone);            

            Engenheiro engenheiro = new Engenheiro();
            engenheiro.Nome = "Júlio";
            engenheiro.Cargo = "Engenheiro Mecânico";
            engenheiro.Especialidade = "Motores";

            Engenheiro engenheiroClone = (Engenheiro)engenheiro.Clone();
            engenheiroClone.Nome = "João";
            engenheiroClone.Especialidade = "Fluidos";

            WriteLine(engenheiro);
            WriteLine(engenheiroClone);
        }
    }
}

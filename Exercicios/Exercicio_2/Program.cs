using System;
namespace Exercicio_2
{
    // 1 - Destaque as características mais importantes do padrão usado
    //     R: Fornece uma interface para a criação de famílias de objetos relacionados ou dependentes
    //     sem especificar suas classes concretas. Usa composição para delegar a responsabilidade
    //     de criar um objeto para outra classe. Produz famílias de produtos onde as fábricas concretas
    //     implementam os métodos para criar produtos.

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lista de cursos para alunos por Universidade/Departamento\n");

            Console.WriteLine("Selecione a Universidade:");
            Console.Write("\tUniv1\n\tUniv2\n==> ");
            var opcao1 = Console.ReadLine().ToUpper();

            var alunoFactory = AlunoFactory.CreateAlunoFactory(opcao1);

            Console.WriteLine("\nUniversidade: " + alunoFactory.GetType().Name);

            Console.WriteLine("\nSelecione o Departamento da Universidade:");

            if (opcao1.Equals("UNIV1"))
                Console.WriteLine("Univ1 - Física ou Química");
            else
                Console.WriteLine("Univ2 - Medicina ou Biologia");

            var opcao2 = Console.ReadLine().ToUpper();

            var aluno = alunoFactory.GetAluno(opcao2);

            Console.WriteLine("\nCursos oferecidos para este Departamento");
            Console.WriteLine($"\n{opcao2} - {aluno.GetType().Name}");

            var cursos = aluno.Cursos();
            
            foreach (var item in cursos)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine("-----------------------------");
        }
    }
}

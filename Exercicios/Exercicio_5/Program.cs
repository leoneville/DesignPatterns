using System;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar lanches
            Lanche mistoQuente = new Lanche("Pão de Forma", "Presunto e Queijo", "Tomate e Cebola");
            Lanche cachorroQuente = new Lanche("Pão Francês", "Duas Salsichas", "Mostarda, Molho de Tomate");

            // Fazer a clonagem
            Lanche mistoQuenteClone = mistoQuente.Clone() as Lanche;
            Lanche cachorroQuenteClone = cachorroQuente.Clone() as Lanche;
        }
    }
}

using System;

namespace FactoryMethod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a pizza : ");
            Console.Write("(1)Chocolate\n(2)Mussarela\n(3)Portuguesa\n(4)Quatro Queijos\n--> ");
            var pizzaEscolhida = int.Parse(Console.ReadLine());

            try
            {
                var pizzaFactory = new PizzaFactory();
                var pizza = pizzaFactory.CriarPizza(pizzaEscolhida);

                Console.WriteLine(pizza.Nome);

                foreach (var ingrediente in pizza.Ingredientes)
                    Console.WriteLine(ingrediente);

                Console.WriteLine("\nPizza concluída com sucesso!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}

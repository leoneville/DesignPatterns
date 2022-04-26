using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "NEVILL'S PIZZARIA";
            Console.WriteLine("========= Pizzaria =========");
            Console.Write("Informe o local (S)ão Paulo  (R)io de Janeiro: ");
            var localEscolhido = Console.ReadLine().ToUpper();

            Console.Write("Escolha a pizza (M)ussarela  (C)hocolate: ");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try
            {
                var pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);
                var pizza = pizzaria.MontaPizza(pizzaEscolhida);
                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("\nPizza concluida com sucesso");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}

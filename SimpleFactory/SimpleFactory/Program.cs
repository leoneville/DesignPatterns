using System;

namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "NEVILL'S PIZZARIA";

            Console.WriteLine("========= PIZZARIA =========");
            Console.Write("Informe a pizza (C)hocolate  (M)ussarela: ");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try
            {
                #region Código sem Simple Factory
                //Pizza pizza = null;
                //if (pizzaEscolhida.Equals("C"))
                //{
                //    pizza = new PizzaChocolate();
                //}
                //else if (pizzaEscolhida.Equals("M"))
                //{
                //    pizza = new PizzaMussarela();
                //}
                //else
                //{
                //    Console.WriteLine("A pizza não pôde ser criada.");
                //    return;
                //}
                #endregion

                #region Código com Simple Factory
                Pizza pizza = PizzaSimpleFactory.CriaPizza(pizzaEscolhida);
                #endregion

                pizza.Preparar();
                pizza.Assar(30);
                pizza.Embalar();
                Console.WriteLine("\nPizza concluída com sucesso!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}

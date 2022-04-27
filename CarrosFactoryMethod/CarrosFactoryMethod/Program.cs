using System;

namespace CarrosFactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "FABRICA DE CARROS";
                Console.WriteLine("######################################################");
                Console.WriteLine("## =============== FABRICA DE CARROS ============== ##");
                Console.WriteLine("######################################################\n");

                Console.Write("Digite de qual fabricante você deseja comprar o carro:\n\t- BMW\n\t- Tesla\n==> ");
                string fabricanteEscolhida = Console.ReadLine().ToUpper();

                CarroFactoryMethod fabricante = CarroSimpleFactory.CriarFabricante(fabricanteEscolhida);

                Console.Write("Digite qual categoria você deseja comprar:\n\t- Esportivo\n\t- SUV\n==> ");
                string categoriaEscolhida = Console.ReadLine().ToUpper();

                Veiculo veiculo = fabricante.MontaVeiculo(categoriaEscolhida);
                Console.WriteLine(veiculo.Fabricar());

                Console.WriteLine("Seu veículo já se encontra na concessionária, parabéns pela aquisição... Ficamos felizes em ter você como nosso cliente!");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
            
        }
    }
}

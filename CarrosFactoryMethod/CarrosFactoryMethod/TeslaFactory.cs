using System;

namespace CarrosFactoryMethod
{
    public class TeslaFactory : CarroFactoryMethod
    {
        protected override Veiculo CriarVeiculo(string categoria)
        {
            switch (categoria)
            {
                case "ESPORTIVO":
                    return new TeslaCarroEsportivo();
                case "SUV":
                    return new TeslaCarroSUV();
                default:
                    throw new ArgumentException("Categoria não disponível!");
            }
        }
    }
}

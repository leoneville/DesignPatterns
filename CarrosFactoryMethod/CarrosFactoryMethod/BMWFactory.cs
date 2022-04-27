using System;

namespace CarrosFactoryMethod
{
    public class BMWFactory : CarroFactoryMethod
    {
        protected override Veiculo CriarVeiculo(string categoria)
        {
            switch (categoria)
            {
                case "ESPORTIVO":
                    return new BMWCarroEsportivo();
                case "SUV":
                    return new BMWCarroSUV();
                default:
                    throw new ArgumentException("Categoria não disponível!");
            }
        }
    }
}

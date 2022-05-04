using System;

namespace Exercicio_3
{
    public class MontadoraSimpleFactory
    {
        public static IMontadora CriaCarro(string tipo)
        {
            IMontadora carro = tipo switch
            {
                "C" => new Chevrolet(),
                "F" => new Ford(),
                "H" => new Honda(),
                _ => throw new ArgumentException("Não foi possível criar este carro")
            };

            return carro;
        }
    }
}

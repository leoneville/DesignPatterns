using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFactoryMethod
{
    public class CarroSimpleFactory
    {
        public static CarroFactoryMethod CriarFabricante(string fabricante)
        {
            switch (fabricante)
            {
                case "BMW":
                    return new BMWFactory();
                case "TESLA":
                    return new TeslaFactory();
                default:
                    throw new ArgumentException("Fabricante não disponível!");
            }
        }
    }
}

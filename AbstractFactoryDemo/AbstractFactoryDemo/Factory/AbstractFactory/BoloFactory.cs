using AbstractFactoryDemo.Domain.Enums;
using AbstractFactoryDemo.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Factory.AbstractFactory
{
    public sealed class BoloFactory : MassasAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoBolo)tipoMassa;
            //Console.WriteLine((TipoBolo)tipoMassa);

            switch (tipoBolo)
            {
                case TipoBolo.Chocolate:
                {
                    return new BoloChocolate();
                }
                case TipoBolo.Laranja:
                {
                    return new BoloChocolate();
                }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}

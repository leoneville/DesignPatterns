using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2
{
    //Concrete Creator
    public class PizzaFactory : PizzaFactoryMethod
    {
        #region utilizando if - else if
        //public override Pizza CriarPizza(int tipo)
        //{
        //    if (tipo == 1)
        //        return new PizzaChocolate();
        //    else if (tipo == 2)
        //        return new PizzaMussarela();
        //    else if (tipo == 3)
        //        return new PizzaPortuguesa();
        //    else if (tipo == 4)
        //        return new PizzaQuatroQueijos();
        //    else
        //        throw new ArgumentException("Pizza não encontrada!");
        //}
        #endregion

        #region utilizando dictionary
        public override Pizza CriarPizza(int tipo)
        {
            var factory = PizzaFactories[tipo];
            return factory();
        }

        public static Dictionary<int, Func<Pizza>> PizzaFactories = new Dictionary<int, Func<Pizza>>
        {
            { 1, ()=> new PizzaChocolate() },
            { 2, ()=> new PizzaMussarela() },
            { 3, ()=> new PizzaPortuguesa() },
            { 4, ()=> new PizzaQuatroQueijos() },
        };
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RJPizzaMussarela : Pizza
    {
        public RJPizzaMussarela()
        {
            Nome = "Pizza de mussarela carioca";
            massa = "Massa fina crocante carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Queijo parmesão");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}

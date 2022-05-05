using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public abstract class LancheCreator
    {
        protected abstract Lanche CriaLanche();
        
        public void MontaLanche()
        {
            Lanche lanche = CriaLanche();
            string pao = lanche.GetPao();
            string recheio = lanche.GetRecheio();
            string condimentos = lanche.GetCondimentos();

            PrepararPao(pao);
            PrepararRecheio(recheio);
            PrepararCondimentos(condimentos);
        }

        private void PrepararPao(string pao)
        {
            Console.WriteLine("Preparando pão: " + pao);
        }

        private void PrepararRecheio(string recheio)
        {
            Console.WriteLine("Preparando recheio: " + recheio);
        }

        private void PrepararCondimentos(string condimentos)
        {
            Console.WriteLine("Preparando condimentos: " + condimentos);
        }
    }
}

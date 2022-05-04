using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    public class Cozinha
    {
        public void MontaLanche(CriadorLanche criadorLanche)
        {
            criadorLanche.AddPao();
            criadorLanche.AddRecheio();
            criadorLanche.AddVegetais();
            criadorLanche.AddCondimentos();
        }
    }
}

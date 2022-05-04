using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    public class LancheNormal : CriadorLanche
    {
        public LancheNormal()
        {
            lanche = new Lanche("Lanche Normal - Hambúrguer Especial");
        }

        public override void AddPao()
        {
            lanche["pao"] = "de Hamburguer com gergelim";
        }

        public override void AddRecheio()
        {
            lanche["recheio"] = "Filé Mignon de 120g";
        }

        public override void AddVegetais()
        {
            lanche["vegetais"] = "Alface, tomate, cebola, rúcula";
        }

        public override void AddCondimentos()
        {
            lanche["condimentos"] = "molho de mostarda com mel";
        }
    }
}

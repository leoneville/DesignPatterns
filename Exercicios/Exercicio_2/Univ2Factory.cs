using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    public class Univ2Factory : AlunoFactory
    {
        public override IAluno GetAluno(string alunoDepartamento)
        {
            return alunoDepartamento switch
            {
                "MEDICINA" => new Univ2Medicina(),
                "BIOLOGIA" => new Univ2Biologia(),
                _ => null
            };
        }
    }
}

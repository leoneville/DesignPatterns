using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPrototype
{
    class Engenheiro : Funcionario
    {
        public string Especialidade { get; set; }

        public override Funcionario Clone()
        {
            return (Funcionario)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format($"{Nome} - {Cargo} - {Especialidade}");
        }
    }
}

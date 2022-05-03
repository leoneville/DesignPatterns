using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPrototype
{
    class Programador : Funcionario
    {
        public string Linguagem { get; set; }

        public override Funcionario Clone()
        {
            return (Funcionario)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format($"{Nome} - {Cargo} - {Linguagem}");
        }
    }
}

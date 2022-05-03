using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPrototype
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public abstract Funcionario Clone();
    }
}

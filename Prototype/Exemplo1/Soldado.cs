using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    internal class Soldado : ICloneable
    {
        public string Nome { get; set; }
        public string Arma { get; set; }
        
        public Soldado() { }
        
        public Soldado(Soldado s)
        {
            this.Nome = s.Nome;
            this.Arma = s.Arma;
        }
        
        public object Clone()
        {
            return new Soldado(this);
        }
    }
}

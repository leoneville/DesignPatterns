using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPadrao
{
    public class Email
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public override string ToString()
        {
            return ($"Destino: {To} - Origem: {From}\nAssunto: {Subject}\n  \t{Body}\n");
        }
    }
}

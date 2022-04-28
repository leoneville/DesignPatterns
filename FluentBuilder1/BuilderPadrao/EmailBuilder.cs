using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPadrao
{
    public class EmailBuilder
    {
        private readonly Email _email;
        public EmailBuilder()
        {
            _email = new Email();
        }

        public void To(string destino)
        {
            _email.To = destino;
        }

        public void From(string origem)
        {
            _email.From = origem;
        }

        public void Subject(string titulo)
        {
            _email.Subject = titulo;
        }

        public void Body(string conteudo)
        {
            _email.Body = conteudo;
        }

        public Email CriaEmail()
        {
            return _email;
        }
    }
}

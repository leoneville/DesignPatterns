using System;

namespace BuilderPadrao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailBuilder = new EmailBuilder();

            emailBuilder.To("microsoft@email.com");
            emailBuilder.From("leoneville@yahoo.com");
            emailBuilder.Subject("Microsoft Build");
            emailBuilder.Body("Microsoft Build 2021\n\t25 a 27 de Maio 2022" + "\n\tNovidades Windows, Azure, Office e mais");

            var email = emailBuilder.CriaEmail();

            Console.WriteLine(email.ToString());
        }
    }
}

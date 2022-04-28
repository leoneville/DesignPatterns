using System;

namespace BuilderPadrao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sem fluent interface
            //var emailBuilder = new EmailBuilder();

            //emailBuilder.To("microsoft@email.com");
            //emailBuilder.From("leoneville@yahoo.com");
            //emailBuilder.Subject("Microsoft Build");
            //emailBuilder.Body("Microsoft Build 2021\n\t25 a 27 de Maio 2022" + "\n\tNovidades Windows, Azure, Office e mais");
            #endregion

            #region com fluent interface
            var emailBuilder = new EmailBuilder()
                               .To("microsoft@email.com")
                               .From("leoneville@yahoo.com")
                               .Subject("Microsoft Build")
                               .Body("Microsoft Build 2021\n\t25 a 27 de Maio 2022" + 
                                     "\n\tNovidades Windows, Azure, Office e mais")
                               .CriaEmail();
            #endregion


            Console.WriteLine(emailBuilder.ToString());
        }
    }
}

using System;

namespace SimpleFactory
{
    internal class Nokia : ICelular
    {
        public void Especificacao()
        {
            Console.WriteLine("Celular Nokia");
        }
    }
}

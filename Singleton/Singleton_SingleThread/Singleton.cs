﻿using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance;
        private int numeroDeInstancias = 0;

        private Singleton()
        {
            Console.WriteLine("Instanciando dentro do construtor privado");
            numeroDeInstancias++;
            Console.WriteLine($"Número de Instancias = {numeroDeInstancias}");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine("Criando a primeira instancia!");
                    instance = new Singleton();
                }
                
                return instance;
            }
        }
    }
}

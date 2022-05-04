﻿using System;
using System.Threading.Tasks;
using Singleton_ThreadSafety;

namespace Singleton_MultiThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => AcessoThread1(),
                () => AcessoThread2()
            );
        }

        private static void AcessoThread1()
        {
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Thread 1 ");
        }

        private static void AcessoThread2()
        {
            Singleton s2 = Singleton.Instance;
            Console.WriteLine("Thread 2");
        }
    }
}

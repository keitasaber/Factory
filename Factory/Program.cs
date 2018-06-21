using Factory.ConcreteComponent;
using Factory.Interface;
using System;

namespace Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SecureFactory secureFactory = new SecureFactory();
            IConnection connection = secureFactory.CreateConnection("Oracle");

            Console.WriteLine(connection.Description());

            Console.ReadKey();
        }
    }
}
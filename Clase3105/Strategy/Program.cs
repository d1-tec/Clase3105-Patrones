using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new ConcreteStrategyA()) { Name = "Juan" };
            client.ExecuteOperation();
            client.Strategy = new ConcreteStrategyB();
            client.ExecuteOperation();
            Console.ReadLine();
        }
    }
}

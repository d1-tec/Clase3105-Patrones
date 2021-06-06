using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface(Client client)
        {
            Console.WriteLine($"Algorithm in A, hello {client.Name}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface(Client client)
        {
            Console.WriteLine("Algorithm in B");
        }
    }
}

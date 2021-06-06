using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Client
    {
        public string Name { get; set; }
        public Strategy Strategy { get; set; }

        public Client(Strategy strategy)
        {
            this.Strategy = strategy;
        }

        public void ExecuteOperation()
        {
            this.Strategy.AlgorithmInterface(this);
        }
    }
}

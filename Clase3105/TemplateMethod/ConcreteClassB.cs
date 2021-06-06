using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ConcreteClassB : ParentClass
    {
        public override void HookOperation()
        {
            Console.WriteLine("Another thing that i want...");
        }
    }
}

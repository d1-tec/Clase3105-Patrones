using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ConcreteClassA : ParentClass
    {
        public override void PrimitiveOperationA()
        {
            Console.WriteLine("A - ConcreteClassA");
        }

        public override void PrimitiveOperationB()
        {
            base.PrimitiveOperationB();
            Console.WriteLine("Also i want to do ...");
        }
    }
}

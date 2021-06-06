using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ParentClass
    {
        public void TemplateMethod()
        {
            this.SomeOperationThatDoesNotChange();
            this.PrimitiveOperationA();
            this.PrimitiveOperationB();
            this.HookOperation();
        }

        public void SomeOperationThatDoesNotChange()
        {
            Console.WriteLine("Fixed part of the algorithm");
        }

        public virtual void PrimitiveOperationA()
        {
            Console.WriteLine("Default A - Parent");
        }

        public virtual void PrimitiveOperationB()
        {
            Console.WriteLine("Default B - Parent");
        }

        public virtual void HookOperation() { }
    }
}

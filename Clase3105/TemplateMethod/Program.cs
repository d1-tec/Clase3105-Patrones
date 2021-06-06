using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ParentClass parent = new ParentClass();
            parent.TemplateMethod();

            Console.WriteLine("*******");

            ConcreteClassA childrenA = new ConcreteClassA();
            childrenA.TemplateMethod();

            Console.ReadLine();
        }
    }
}

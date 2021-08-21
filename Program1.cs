using System;
using System.Collections.Generic;
using System.Text;
using static NewAssignment3.Program;

namespace Assignment3
{
    class Program
    {
        static void Main()
        {
            //ABSTRACT METHOD
            AbstractMethodDemo abstractMethodDemo = new AbstractDriver();
            abstractMethodDemo.Print();

            //EXTENSION METHOD
            Console.WriteLine("Extension Method Result");
            Console.WriteLine(ExtensionMethodDemo.Subtract(10));
            Console.WriteLine(ExtensionMethodDemo.Subtract(55, 45));
            Console.WriteLine(ExtensionMethodDemo.Division(42));
            Console.WriteLine(ExtensionMethodDemo.Division(50, 8));

            //INSTANCE METHOD
            Console.WriteLine("Instance Method Result");
            InstanceMethodDemo instanceMethodDemo = new InstanceMethodDemo();
            Console.WriteLine(instanceMethodDemo.Add(40));
            Console.WriteLine(instanceMethodDemo.Add(20, 30));
            Console.WriteLine(instanceMethodDemo.Multiply(6));
            Console.WriteLine(instanceMethodDemo.Multiply(2, 3));

            //PARTIAL METHOD
            PartialMethodDemo partialMethodDemo = new PartialMethodDemo();
            partialMethodDemo.Print();

            //STATIC METHOD
            StaticMethodDemo.Area();
        }
        
    }
    }







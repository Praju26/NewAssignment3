using System;
using System.Collections.Generic;
using System.Text;

namespace NewAssignment3
{
    class Program
    {
        public abstract class AbstractMethodDemo
        {
            public abstract void Print();
        }

        public class AbstractDriver : AbstractMethodDemo
        {
            public override void Print()
            {
                Console.WriteLine("Abstract Print method implemented in AbstractDriver Class");
            }
        }
    }
}



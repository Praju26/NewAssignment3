using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    partial class PartialMethodDemo
    {
        public  void PartialPrint()
        {
            Console.WriteLine("Hello from partial method");
        }

        internal void Print()
        {
            throw new NotImplementedException();
        }
    }

}



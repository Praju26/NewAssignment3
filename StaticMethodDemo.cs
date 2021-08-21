using System;
using System.Text;
namespace Assignment3
    {
        class StaticMethodDemo
        {
        public static float Side = 5;
            public static void Area(float side)
            {
                Console.WriteLine($"Area: {side*side}");
            }

        internal static void Area()
        {
            throw new NotImplementedException();
        }
    }
    }


    





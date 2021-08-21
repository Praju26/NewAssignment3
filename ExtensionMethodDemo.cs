using System;

namespace Assignment3
{
    public static class ExtensionMethodDemo
    {

        public static int Subtract(this int FirstNum, params int[] SecondNum)
        {
            foreach (int item in SecondNum)
            {
                FirstNum -= item;
            }

            return FirstNum;
        }

        public static int Division(this int FirstNum, params int[] SecondNum)
        {
            foreach (int item in SecondNum)
            {
                FirstNum /= item;
            }

            return FirstNum;
        }

    }
}



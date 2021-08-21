using System;
namespace Assignment3
{
    public class InstanceMethodDemo
    {
        public int Substract(int FirstNum, params int[] SecondNum)
        {
            foreach (int item in SecondNum)
            {
                FirstNum += item;
            }

            return FirstNum;
        }

        public int Division(int FirstNum, params int[] SecondNum)
        {
            foreach (int item in SecondNum)
            {
                FirstNum *= item;
            }

            return FirstNum;
        }

        internal bool Multiply(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal bool Multiply(int v)
        {
            throw new NotImplementedException();
        }

        internal bool Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        internal bool Add(int v)
        {
            throw new NotImplementedException();
        }
    }
}





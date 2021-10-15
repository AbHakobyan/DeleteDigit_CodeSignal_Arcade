using System;

namespace DeleteDigit_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 222250;
            int v = deleteDigit(x);
            Console.WriteLine(v);
        }

        static int deleteDigit(int n)
        {

            var strN = n.ToString();
            int max = 0;

            for (int i = 0; i < strN.Length; i++)
            {
                if (int.Parse(strN.Remove(i, 1)) > max)
                {
                    max = int.Parse(strN.Remove(i, 1));
                }
            }

            return max;
        }
    }
}

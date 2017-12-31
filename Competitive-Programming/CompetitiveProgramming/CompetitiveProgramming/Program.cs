using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] ArrayForExample = { 2, 3, 1, 0, 2, 5, 3, 8, 7 };
            ArryQuestion1 cheek = new ArryQuestion1();
            int DuplecateNumber = cheek.Duplecate(ArrayForExample);
            Console.WriteLine("the duplicate number is : " + DuplecateNumber);
        }
    }
}

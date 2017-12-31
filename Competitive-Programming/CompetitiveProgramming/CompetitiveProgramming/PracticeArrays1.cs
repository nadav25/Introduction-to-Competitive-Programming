using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitiveProgramming
{
    //---------------------Example--------------------
    //class Program 
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Question 1");
    //        int[] ArrayForExample = { 2, 3, 1, 0, 2, 5, 3, 8, 7 };
    //        ArryQuestion1 cheek = new ArryQuestion1();
    //        int DuplecateNumber = cheek.Duplecate(ArrayForExample);
    //        Console.WriteLine("the duplicate number is : " + DuplecateNumber);
    //    }
    //}


    /// <summary>
    /// An array contains n numbers ranging from 0 to n-1. There are some numbers duplicated in the
    /// array.It is not clear how many numbers are duplicated or how many times a number gets duplicated.How do you
    /// find a duplicated number in the array? For example, if an array of length 9 contains the numbers { 2, 3, 1, 0, 2, 5, 3 , 8, 7 },
    /// the implemented function(or method) should return either 2 or 3.  
    /// </summary>
    /// --------------------------Answer-----------------------
    /// The range of values in the array will be between 0 and n-1, if we place each value in its cell array
    /// and at the time of placement we will find that the number is already positioned in the same position
    /// so that means we have a duplicate number
    public class ArryQuestion1
    {
        public int Duplecate(int[] i_Arry)
        {
            int DuplecateNumber = -1;  //If there is no duplicate number, it will returned -1
            for (int i = 0; i < i_Arry.Length; i++)
            {
                while (i_Arry[i] != i)
                {
                    if (i_Arry[i] == i_Arry[i_Arry[i]])
                    {
                        DuplecateNumber = i_Arry[i];      // StyleCop C#, only 1 return in mathod.
                        break;
                    }
                    int temp = i_Arry[i];
                    i_Arry[i] = i_Arry[temp];
                    i_Arry[temp] = temp;
                }
            }

            return DuplecateNumber;  // The last duplicate number will be returned
        }
    }
}

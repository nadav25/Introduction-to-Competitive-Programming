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
            Console.WriteLine("----------Question 2----------");
            int[,] arr = { { 1, 4, 8 }, {11,12,15 } , { 20,25,27 }};
            PracticeArrays2 examination = new PracticeArrays2();
            Console.WriteLine("pleese enter number to serch in mat");
            int serch = int.Parse(Console.ReadLine());
            bool Exists = examination.FindInMat(arr, serch);
            if(Exists == true)
            { 
                Console.WriteLine($"the number {serch} is Exists the mat");
            }
            else
            {
                Console.WriteLine($"the number {serch} is not Exists in the mat ");
            }
        }
    }

    /// <summary>
    /// In a 2-D matrix, every row is increasingly sorted from left to right, and the last number in each
    ///row is not greater than the first number of the next row.A sample matrix follows.Please implement a function to
    ///check whether a number is in such a matrix or not.It returns true if it tries to find the number 7 in the sample
    ///matrix, but it returns false if it tries to find the number 12.
    ///------------------------Answr-------------------------------
    ///The matrix is sorted in ascending order, so to solve the problem in the most efficient way
    ///we will use binary search
    /// </summary>
    class PracticeArrays2
    {
        public bool FindInMat(int[,] i_Mat , int i_SerchNum )
        {
            bool IsFound = false;
            int Col = i_Mat.GetLength(0);  // first Dim
            int Row = i_Mat.GetLength(1);  // secend Dim
            int Start = 0;
            int End = Row * Col - 1;
            // Binary search
            while ( Start <= End )
            {
                int mid = Start + (End - Start) / 2;
                int row = mid / Col;
                int cols = mid % Col;
                int num = i_Mat[row, cols];

                if (num == i_SerchNum)
                {
                    IsFound = true;
                    break;
                }

                if (num > i_SerchNum)
                {
                    End = mid - 1;
                }
                else
                {
                    Start = mid + 1;
                }
            }

            return IsFound;
        }
    }
}

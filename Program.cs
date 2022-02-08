using System;

namespace MultiplicationTable
{
    class Program
    { 
        static void Main()
        {
            // Create a 10 by 10 rectangular array
            int[,] multTable = new int[10,10];
            // Display the table header
            Console.WriteLine("Multiplication table of 1 through 10");
            // Traverse the rows in the table
            for(int row = 0; row < 10; row++)
                // Traverse the colums i nthe table
                for (int column = 0; column < 10; column++)
                {
                    // Set Element to row+1 times column+1
                    multTable[row, column] = (row + 1) * (column + 1);
                    // DIsplay value after computing it
                    Console.Write(multTable[row, column]);
                    //  if not last column, issue a tab
                    if (column < 9) Console.Write("\t");
                    // Other wise send cursor to next line
                    else Console.WriteLine();
                }
        }
    }
}
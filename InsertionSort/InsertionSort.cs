using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    static class InsertionSort
    {
        static public void StartProgram()
        {
            Console.WriteLine("Welcome in Insertion Sort Program !");
            Console.Write("How much elements does there have to be on your table?\t");
            int numberOfElements = int.Parse(Console.ReadLine()); // number of elements in table
            int[] tab = new int[numberOfElements]; //create empty table
            Console.Clear();
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write($"Give number for {i + 1}-element:\t");
                tab[i] = int.Parse(Console.ReadLine()); // filling the table with user-entered elements
                Console.Clear();
            }
            Console.Write("Your unsorted table:\t");
            foreach (int item in tab)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item + "\t");
            }
            Console.ForegroundColor = ConsoleColor.White;
            int temporary;
            for (int i = 1; i < numberOfElements; i++)
            {
                if (tab[i]>=tab[i-1])
                {
                    continue;
                }
                else
                {
                    temporary = tab[i];
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (temporary<tab[j])
                        {
                            tab[j+1] = tab[j];
                            if (j==0)
                            {
                                tab[j] = temporary;
                                break;
                            }
                            continue;
                        }
                        else
                        {
                            tab[j] = temporary;
                            break;
                        }
                    }
                }
            }
            Console.Write("\nNow your table is sorted:\t");
            foreach (int? item in tab)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item + "\t");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

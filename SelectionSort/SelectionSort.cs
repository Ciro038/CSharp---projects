using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    static class SelectionSort
    {
        public static void StartProgram()
        {
            Console.WriteLine("Hello in selection sort program! :D");
            Console.Write("How much elements does there have to be on your table?\t");
            int numberOfElements = int.Parse(Console.ReadLine()); // number of elements in table
            int[] tab = new int[numberOfElements]; //create empty table
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write($"Give number for {i+1}-element:\t");
                tab[i]=int.Parse(Console.ReadLine()); // filling the table with user-entered elements
                Console.Clear();
            }
            Console.Write("Your unsorted table:\t");
            foreach (int item in tab)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item+"\t");
            }
            Console.ForegroundColor = ConsoleColor.White;
            int[] currentElement=new int[2]; //initialization variable for storage the lowest value of element and his index
            for (int j = 0; j < numberOfElements-1; j++)
            {
                currentElement[0] = tab[j]; // value of j-element
                currentElement[1] = j; //index of j-element
                for (int k = j+1; k < numberOfElements; k++)
                {
                    if (tab[j]>tab[k])
                    {
                        currentElement[0] = tab[k]; //the lowest value
                        currentElement[1] = k; //index od the lowest element
                    }
                }
                tab[currentElement[1]] = tab[j];
                tab[j] = currentElement[0];
            }
            Console.Write( "\nNow your table is sorted:\t");
            foreach (int? item in tab)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(item+"\t");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

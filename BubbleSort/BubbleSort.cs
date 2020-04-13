using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    static class BubbleSort
    {
        public static void BubbleProgram()
        {
            Console.Write("Hello in Bubble sort program! :D\nGive me how much elements does your table have: ");
            int tabNumber = int.Parse(Console.ReadLine());
            int[] tab = new int[tabNumber]; //create empty table
            for (int i = 0; i < tabNumber; i++)
            {
                Console.WriteLine($"Give me {i+1} element of yours table: ");
                tab[i] = int.Parse(Console.ReadLine()); // filling the table with user-entered elements

            }
            Console.Clear();
            Console.Write("Your table: ");
            foreach (int item in tab)
            {
                Console.Write(item+"\t");
            }
            Console.Write("\n");
            bool shouldRepeat;
            do
            {
                shouldRepeat = false; // initialization variable that tells if a change has occurred
                for (int i = 0; i < tab.Length-1; i++)
                {
                    int currentElement = tab[i];
                    int nextElement = tab[i + 1];
                    if (currentElement>nextElement)
                    {
                        shouldRepeat = true; 
                        tab[i] = nextElement;
                        tab[i + 1] = currentElement;
                    }
                }
            } while (shouldRepeat);
            Console.Write("Your sorted table: ");
            foreach (int item in tab)
            {
                Console.Write(item+"\t");
            }
        }
    }
}

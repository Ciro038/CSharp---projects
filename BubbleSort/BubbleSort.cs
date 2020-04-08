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
            Console.WriteLine("Hello in Bubble sort program! :D\nGive me how much elements have yours table:");
            int tabNumber = int.Parse(Console.ReadLine());
            int[] tab = new int[tabNumber];
            for (int i = 0; i < tabNumber; i++)
            {
                Console.WriteLine($"Give me {i+1} element of yours table: ");
                tab[i] = int.Parse(Console.ReadLine());

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
                shouldRepeat = false;
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

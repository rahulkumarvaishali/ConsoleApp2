using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A  Number: ");
            int x = int.Parse(Console.ReadLine());
            int y = 1;

            for (int a = 0; a < 4; a++)
            {
                if (y % 2 == 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{x} ");
                    }
                    y++;
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{x}");
                    }
                    y++;
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
    
}

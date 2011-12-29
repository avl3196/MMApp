using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=100;i++)
            {
                if ((i % 3 == 0) && !(i % 5 == 0))
                {
                    Console.WriteLine("Modern");
                }
                if ((i % 5 == 0) && !(i % 3 == 0))
                {
                    Console.WriteLine("Medical");
                }
                if (!(i % 5 == 0) && !(i % 3 == 0))
                {
                    Console.WriteLine(i.ToString());
                }
            }            
            Console.WriteLine("Press any key...");
            Console.Read();

        }
    }
}

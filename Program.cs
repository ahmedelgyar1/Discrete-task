using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace prefect_number_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the frist number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            for (int number = start; number <= end; number++)
            {
                for (int x = 1; x <= end; x++)
                {
                    if (number % x == 0 && number != x)
                    {
                        count += x;
                    }
                      
                }
                if (count == number)
                {
                    Console.WriteLine("The prefect number is = "+ number);
                    
                }
                count = 0;
            }
        }  
    }
}

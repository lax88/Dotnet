using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //basic program to read key from user and display it in console
            Console.WriteLine("Enter a key:");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Write("You entered the key " +  keyInfo.KeyChar);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Binary_input_to_hexidec_21._11._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number: ");
            string bin = Console.ReadLine();
            int result = 0;
            int pv = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] == '1')
                {
                    result += pv;
                }
                pv *= 2;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}






        
    


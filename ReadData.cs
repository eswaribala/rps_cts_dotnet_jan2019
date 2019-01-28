using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEDemo
{
    class ReadData
    {
        public static void InputName()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi{0}", name);

        }
        public static void InputAge()
        {
            Console.WriteLine("Enter the Age");
            byte age = Convert.ToByte(Console.ReadLine());
            byte futureAge = (byte)(age + 10);
            Console.WriteLine("After 10 years I will be {0}", futureAge);
            //conditional statement
            if (futureAge > 57)
                Console.WriteLine("Pension will start with your future age");
            else
                Console.WriteLine("Long way to go...");
        }
    }
}

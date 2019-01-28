using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEDemo
{
    class DataTypeDemo
    {
       public static void ShowValues()
        {
            bool status = false;
            //-128 to 127
            sbyte id = 127;
            int value = 0xFF;
            //by deafult fractional values are double
            float discount = 0.5f;
            double offer = 0.7;
            decimal data = 0.78m;
            //unicode character
            char letter = '\u0061';
            string message = "I say, \"We will go to movie\"";
            //formatting
            Console.WriteLine("Id={0}\t Status={1}\t Value={2}", id, status,value);
            Console.WriteLine("Letter={0}", letter);
            Console.WriteLine("Message={0}", message);


        }

    }
}

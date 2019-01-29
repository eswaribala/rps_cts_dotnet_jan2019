using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString();
            Console.ReadLine();
        }


        static void ReverseString()
        {
            string userName = "Parameswari";
            
            //reverse the string
            char[] userNameArray = userName.ToCharArray();
            
            int length = userNameArray.Length-1;
            Console.WriteLine(length);
            //Console.WriteLine(userNameArray[length - 1]);
            //Console.WriteLine(userNameArray[length - 2]);
           // Console.WriteLine(userNameArray[length - 3]);
           // Console.WriteLine(userNameArray[length - 4]);

          //method1
           for (int i=userNameArray.Length-1;i>=0;i--)
                Console.Write(userNameArray[i]);

            Console.WriteLine("\n");
            //method 2
            Array.Reverse(userNameArray);
            foreach(char value in userNameArray)
                   Console.Write(value);

            //method 3
            length = userNameArray.Length - 1;
            Console.WriteLine();
            //entry controlled loop
            while(length>=0)
            {

                Console.Write(userNameArray[length]);
                length--;

            }
            //method 4
            //exit controlled loop
            Console.WriteLine();
            length = userNameArray.Length-1;
            do
            {
                Console.Write(userNameArray[length]);
                length--;

            }
            while (length >= 0);

            
            


        }

    }
}

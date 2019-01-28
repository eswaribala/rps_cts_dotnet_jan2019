using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author:Parameswari
 * Date Created:28-01-2019
 * 
 */

namespace IDEDemo
{

    /// <summary>
    /// Test Documentation
    /// </summary>

    class Utility
    {
       
    
        static void Main(string[] args)
        {

            ReadData.InputName();
            ReadData.InputAge();

            DataTypeDemo.ShowValues();

            Console.WriteLine("!Ready to Rock!!!!");
       
            //make console to wait for user input
            Console.ReadLine();
        }
       
    }

}

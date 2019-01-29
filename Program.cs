
using AutoInsurance.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance
{
    class Program
    {
        static void CreateVehicle()
        {
            //Object for Vehicle
            Vehicle vehicleObj = new Vehicle();
            //setter
            Console.WriteLine("Enter Registration No");
            vehicleObj.RegistrationNo = Console.ReadLine();
            Console.WriteLine("Enter Color");
            vehicleObj.Color = Console.ReadLine();
            Console.WriteLine("Enter Engine No");
            vehicleObj.EngineNo = Console.ReadLine();
            Console.WriteLine("Enter Chasis No");
            vehicleObj.ChasisNo = Console.ReadLine();
            Console.WriteLine("Enter Date of purchase");
            string date = Console.ReadLine();
            vehicleObj.DOP = Convert.ToDateTime(date);
            Console.WriteLine("Enter Maker");
            vehicleObj.Maker = Console.ReadLine();

            //getter
            Console.WriteLine("Registration No={0}", vehicleObj.RegistrationNo);
            Console.WriteLine("Engine No={0}", vehicleObj.EngineNo);
            Console.WriteLine("Chasis No={0}", vehicleObj.ChasisNo);
            Console.WriteLine("Maker={0}", vehicleObj.Maker);
            Console.WriteLine("DOP={0}", vehicleObj.DOP.ToLongDateString());
        }


        static void CreatePolicyHolder()
        {
            PolicyHolder policyHolder = new PolicyHolder
            {
                PolicyNo = 4868428,
                FromDate = new DateTime(2009, 1, 1),
                ToDate = new DateTime(2020, 1, 1),
                Address = "Chennai",
                DOB = new DateTime(1970, 2, 12),
                Email = "Param@gmail.com",
                GenderType = Gender.FEMALE,
                NameInsured = "Parameswari",
                PhoneNo = 39694365634
            };
        }

        static void Main(string[] args)
        {
            CreateVehicle();
            CreatePolicyHolder();
            
            Console.Read();


        }
    }
}

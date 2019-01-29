using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance.models
{
    //default visibility at class level internal
    class Vehicle
    {
        //fields
        private string registrationNo;
        private string engineNo;

        public string EngineNo
        {
            get { return engineNo; }
            set { engineNo = value; }
        }

        private string chasisNo;

        public string ChasisNo
        {
            get { return chasisNo; }
            set { chasisNo = value; }
        }


        private string maker;

        public string Maker
        {
            get { return maker; }
            set { maker = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private DateTime dop;

        public DateTime DOP
        {
            get { return dop; }
            set { dop = value; }
        }



        //properties

        public String RegistrationNo
        {
            get
            {
                //to retrive value from the variable
                return this.registrationNo;
            }
            set
            {

                //to assign value to variable
                this.registrationNo = value;
            }
        }
      


    }
}

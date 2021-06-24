using System;

namespace VehicleLot
{
    class Program
    {

        static void Main(string[] args)
        {            
           string myCarMake = "Ford";
           string myCarModel = "Bronco";
           string mySemiMake = "Peterbilt";
           string mySemiModel = "359";
           
            Car myCar = new Car();
            myCar.returnCarMake(myCarMake);
            myCar.returnCarModel(myCarModel);

            Semi mySemi = new Semi();
            mySemi.returnSemiMake(mySemiMake);
            mySemi.returnSemiModel(mySemiModel);
            mySemi.setTowStatus(true);
            Console.WriteLine($"{mySemiMake} {mySemiModel} " + mySemi.getTowStatus());
        }
    }

    public class Vehicle
    {
        protected void displayModel(string model)
        {
            Console.WriteLine($"The model is {model}.");
        }

        protected void displayMake(string make)
        {
            Console.WriteLine($"The make is {make}.");
        }
    }

    public class Car : Vehicle
    {
        public void returnCarMake(string carMake)
        {
            displayMake(carMake);
        }
        public void returnCarModel(string carModel)
        {
            displayModel(carModel);
        }
    }

    public class Semi : Vehicle
    {
        bool isTowing;

        public void returnSemiMake(string semiMake)
        {
            displayMake(semiMake);
        }
        public void returnSemiModel(string semiModel)
        {
            displayModel(semiModel);
        }

        internal void setTowStatus(bool status)
        {
            isTowing = status;
        }

        internal string getTowStatus()
        {
            if(isTowing)
            {
                return "is towing";
            }
            else{
                return "is not towing";
            }
            
        }
    }
}

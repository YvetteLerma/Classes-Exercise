using System;
namespace Classes
{
    public class Car
    {
        public Car()
        {

        }
        //Constructors
        //- a special member method that has the same name as its class
        public Car(string make, string model, int year)
          
        {
            Make = make;
            Model = model;
            Year = year;
        }


        //fields
        //properties
        //methods

        //Create a Make propert of type string that is public
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        
    }
}


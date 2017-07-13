using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence_and_Polymorphyism
{
    class Automobile : Vehicle
    {
        //pro double tab creates a template for properties
        //cort double tab creates a template for constructors
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels {get;}
        public int NumberOfDoors {get;}
        public float WheelSize {get;}

        public Automobile()
        {
            //default
        }

        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, 
                          int carryingCapacity, string color, double movementSpeed)
        {
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }




    }
}

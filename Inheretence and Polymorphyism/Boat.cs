using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence_and_Polymorphyism
{
    class Boat : Vehicle
    {
        // To make one class the child of another, you only need to place a ':' and add the parent class after.

        private double waterDrag;

        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }

        public Boat()
        {
            //default
        }

        //Override allows you to take a method from a parent class and make it unique to this class.
        // In this example, we are changing movement, to include water drag, because that is a unique movement calculation to boats.
        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag;
        }


    }
}

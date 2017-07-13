using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence_and_Polymorphyism
{
    class Vehicle
    {

        //Fields for our vehicle class
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;

        private float gearRatio;
        private float engineSize;

        //Properties. Can type 'prop' then double tab to get this full line.
        public int Seats { get; }
        public int CarryingCapacity { get; }
        public string Color { get; set; }
        public double DistanceTraveled { get; }

        //Constructors. Can type 'ctor' then double tab to get this full line.

        public Vehicle()
        {
            //Default
        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            distanceTraveled = 0.0d;
        }

        //Methods
        //First use of 'virtual'.

        public virtual void Move()
        {
            distanceTraveled += movementSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance Traveled:" + distanceTraveled + "\n";
        }

        
    }
}

using System;

namespace LW2
{
    public class Vehicle
    {
        private double x, y, cost, speed;
        private int year;
        protected string name;

        public Vehicle(double x, double y, double cost, double speed, int year)
        {
            this.x = x;
            this.y = y;
            this.cost = cost;
            this.speed = speed;
            this.year = year;
        }

        public virtual void Print()
        {
            Console.WriteLine($"=== Info about {name} ===");
            Console.WriteLine($"Coordiantes:\nx = {x}, y = {y}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Cost: {cost}");
            Console.WriteLine($"Year: {year}");
        }
    }

    public class Car: Vehicle
    {
        private string name = "car";
        public Car(double x, double y, double cost, double speed, int year) : base(x, y, cost, speed, year) {
            base.name = name;
        }

        public override void Print() { base.Print(); Console.WriteLine("\n"); }
    }

    public class Plane: Vehicle
    {
        private double height;
        private int countOfPassengers;
        private string name = "plane";

        public Plane(double x, double y, double cost, double speed, int year, double height, int count): base(x, y, cost, speed, year)
        {
            base.name = name;
            this.height = height;
            countOfPassengers = count;
        }

        public override void Print() 
        {
            base.Print();
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Count of passengers: {countOfPassengers}\n");
        }
    }

    public class Ship: Vehicle
    {
        private string portName;
        private int countOfPassengers;
        private string name = "ship";

        public Ship(double x, double y, double cost, double speed, int year, string name, int count): base(x, y, cost, speed, year)
        {
            base.name = name;
            portName = name;
            countOfPassengers = count;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Port name: {portName}");
            Console.WriteLine($"Count of passengers: {countOfPassengers}\n");
        }
    }
}

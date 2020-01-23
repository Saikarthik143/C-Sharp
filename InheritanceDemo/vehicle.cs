using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    abstract class vehicle
    {
       protected string clr;
        public vehicle()
        {
            this.clr = "yellow";
            Console.WriteLine("the color of vehicle is :" + clr);
        }
        public vehicle(string clr)
        {
            this.clr = clr;
            Console.WriteLine("the color of vehicle is parameter :" + clr);
        }
        public abstract void fill();//child should compl override
        public virtual void Start()//child may or may not override
        {
            Console.WriteLine("vehicle started");
        }
        public void Stop()
        {
            Console.WriteLine("vehicle stopped");
        }

    }
    class bus: vehicle
    {
        int seat,speed;
        public bus():base("red")
        {
            this.seat = 4;
            this.speed = 45;
            Console.WriteLine("constructor for bus");
        }
        public override void fill()
        {
            Console.WriteLine("filled with diesel");
        }
        public void Run()
        {
            Console.WriteLine(this.clr+"  bus is running"+"at a speed  "+this.speed+"  the person seat no:  "+this.seat);
        }
    }
    class car : vehicle
    {
        int speed;
        public car()
        {
            this.speed = 60;
            Console.WriteLine("constructor for car");
        }
        public override void fill()
        {
            Console.WriteLine("filled with diesel/petrol/gas");
        }
        public  void Start()
        {
            Console.WriteLine("car started");
        }
        public car(string clr,int spd):base(clr
            )
        {
            this.speed = spd;

        }
        public void drive()
        {
            Console.WriteLine(this.clr + "car is driving" + "at a speed  " + this.speed);
        }

    }
}

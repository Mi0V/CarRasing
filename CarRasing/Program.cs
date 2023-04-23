using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace CarRasing
{
    abstract class Motor
    {
        public delegate void StartCarDelegate();
        public delegate void FinishCarDelegate();
        public event FinishCarDelegate FinishCar;

        public int CarSpeed(Random random, int rand1,int rand2)
        {
            int carSpeed;
            return carSpeed = random.Next(rand1,rand2);
        }

        public void Race(string name,int carSpeed)
        {
            int raceLenght = 0;
            FinishCar += () => Winner(name);

            for(int i = 0; i < 210; i += 10, raceLenght += 10)
            {
                Thread.Sleep(CarSpeed);
                if(raceLenght == 200)
                {
                    FinishCar();
                }
            }
        }

        public void Winner(string name)
        {
            WriteLine($"[BOT]:{name} пересёк финишную черту");
        }
    }

    class Car1 : Motor
    {
        public string _name = "Bugatti";
        //public int _speed { get; set; }

        public Car1()
        {

        }

        public void InCar()
        {
            //int speed;
            //Random random = new Random();
            //_name = "Bugatti";
            //speed = random.Next(100, 230);
            //return speed;

            Race(_name, CarSpeed(new Random(), 100, 230));
            WriteLine($"{CarSpeed(new Random(), 100, 230)}");
        }

       
    }

    class Car2 : Motor
    {
        public string _name = "Ford";
        //public int _speed { get; set; }

        public Car2()
        {

        }

        public void InCar()
        {
            //int speed;
            //Random random = new Random();
            //_name = "Ford";
            //speed = random.Next(90, 225);
            //return speed;
            Race(_name, CarSpeed(new Random(), 100, 230));
            WriteLine($"{CarSpeed(new Random(), 100, 230)}");
        }
    }

    class Car3 : Motor
    {

        public string _name = "Tayoda";
        //public int _speed { get; set; }

        public Car3()
        {

        }

        public void InCar()
        {
            //int speed;
            //Random random = new Random();
            //_name = "Tayoda";
            //speed = random.Next(80, 231);
            //return speed;
            Race(_name, CarSpeed(new Random(), 100, 230));
            WriteLine($"{CarSpeed(new Random(), 100, 230)}");
        }
    }

    //class Rice
    //{
    //    public delegate void StartDelegte(string metods);


    //    public void RIce()
    //    {
    //        Car1 car1 = new Car1();
    //        Car2 car2 = new Car2();
    //        Car3 car3 = new Car3();
    //        int Speed1 = car1.InCar();
    //        int Speed2 = car2.InCar();
    //        int Speed3 = car3.InCar();

    //        if (Speed1 > Speed2 && Speed3)
    //        {
    //            Write($"Победа{car1._name}");

    //        }
    //        else if (Speed2 > Speed1 )
    //        {
    //            Write($"Победа{car2._name}");
    //        }
    //        else if (Speed3 > Speed2 && Speed1)
    //        {
    //            Write($"Победа{car3._name}");
    //        }
    //    }
    //}
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Car1 car1 = new Car1();
            Car2 car2 = new Car2();
            Car3 car3 = new Car3();

            List<Thread> vehicles = new List<Thread>()
            {
                new Thread(car1.InCar),
                new Thread(car2.InCar),
                new Thread(car3.InCar)


            };

            foreach(Thread cars in vehicles)
            {
                cars.Start();

            }

        }
    }
}

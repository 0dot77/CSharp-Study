namespace _08._004_Quiz
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class Car : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Run Run! by Car");
        }
    }

    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly! by Plane");
        }
    }


    class FlyingCar : IRunnable, IFlyable
    {
        private Car c = new Car();
        private Plane p = new Plane();
        public void Run()
        {
            c.Run();
            Console.WriteLine("Run! Run!");
        }

        public void Fly()
        {
            p.Fly();
            Console
                .WriteLine("Fly! FlY");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();
        }
    }
}
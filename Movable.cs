namespace OOPDemonstration
{
    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    public class InterfaceDemo
    {
        public static void Run()
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}

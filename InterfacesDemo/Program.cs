using System;

class Program
{
    static void Main(string[] args)
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();

        Console.ReadKey();
    }
}

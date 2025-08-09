using System;

class Program
{
    static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        genericAnimal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        Console.ReadKey();
    }
}

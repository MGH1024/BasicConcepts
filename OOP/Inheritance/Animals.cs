namespace Inheritance;

// کلاس پایه (والد)
public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
    }
}

// کلاس فرزند 1
public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }
}

// کلاس فرزند 2
public class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming.");
    }
}

// کلاس فرزند 3
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}
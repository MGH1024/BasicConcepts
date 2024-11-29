namespace Inheritence;

// Parent
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

//child one
public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }
}

//child two
public class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming.");
    }
}

//child three
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}
namespace Polymorphism;

public class Animal
{
    public virtual string GetName() => "animal!";
}

public class Dog : Animal
{
    public override string GetName() => "Dog!";
}

public class Cat : Animal
{
    public override string GetName() => "Cat!";
}
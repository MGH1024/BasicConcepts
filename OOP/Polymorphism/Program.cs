using Polymorphism;

Console.WriteLine("Overload============================");
var overloadObj = new OverloadClass();
Console.WriteLine(overloadObj.Add(1,2));
Console.WriteLine(overloadObj.Add(1.25M,2.45M));


Console.WriteLine("Override============================");
var animalList = new List<Animal>
{
    new Cat(),
    new Dog()
};

foreach (var animal in animalList)
{
    Console.WriteLine(animal.GetName());
}
using Polymorphism;

Console.WriteLine("Overload method or compile time polymorphism============================");
var overloadObj = new OverloadClass();
Console.WriteLine(overloadObj.Add(1,2));
Console.WriteLine(overloadObj.Add(1.25M,2.45M));


Console.WriteLine("Overload operator  or run time polymorphism ============================");
var c1 = new ComplexNumber(1.5, 2.5);
var c2 = new ComplexNumber(3.5, 4.5);
var result = c1 + c2; 
Console.WriteLine(result);



Console.WriteLine("Override or run time polymorphism type 1============================");
var animalList = new List<Animal>
{
    new Cat(),
    new Dog()
};

foreach (var animal in animalList)
{
    Console.WriteLine(animal.GetName());
}





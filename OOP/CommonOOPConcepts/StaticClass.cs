namespace CommonOOPConcepts;


//Key Characteristics of a Static Class:

//1-No Instantiation:
//A static class cannot be instantiated. You cannot use the new keyword with it.

//2-All Members Are Static:
//Every field, property, and method in a static class must be static. Instance members are not allowed.

//3-Single Instance in Memory:
//A static class is loaded into memory only once per application domain, making it efficient for global utility methods.

//4-No Inheritance:
//Static classes cannot be inherited, nor can they inherit from any other class.

//5-Belongs to a Type, Not an Object:
//Static members belong to the type itself, rather than to a specific object.




// When to Use a Static Class:

//1-Utility/Helper Methods:
// For example, classes like Math in .NET contain common methods like Math.Sqrt() or Math.Abs().
//
//2-Global Configuration or Constants:
// Use a static class to store global constants or configuration values.
//
//3-Avoiding State:
// Since static classes cannot have instance members, they are good for stateless operations.




// Restrictions of a Static Class:
//1- Cannot be instantiated (new keyword not allowed).
//2-Cannot inherit from any class (even Object) or implement interfaces.
//3-Cannot be used as a base class.
//4-Can only contain static members.




public static class StaticClass
{
    public static string AppName;
    public static int Version;

    //Static constructor
    //A static class can have a static constructor, which is called only once when the class is first accessed.
    //Static constructors are used to initialize static fields or perform setup logic.
    static StaticClass()
    {
        AppName = "My Application";
        Version = 1;
    }

    public static void DisplayInfo()
    {
        Console.WriteLine($"App Name: {AppName}, Version: {Version}");
    }
}
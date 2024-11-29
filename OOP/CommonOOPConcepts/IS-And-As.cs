namespace CommonOOPConcepts;

// 1. is Keyword:
// The is keyword is used to check if an object is of a certain type, and it can be used in conjunction with casting in some scenarios, but it does not perform an actual cast by itself.
//
// Purpose: To check if an object is compatible with a certain type.
// It returns true or false based on the check.
// Can be used with cast if you want to safely check the type before casting.

// 2. as Keyword:
// The as keyword is used for safe casting. It tries to cast an object to the specified type. If the object cannot be cast to that type, it returns null instead of throwing an exception.
//
// Purpose: To attempt a cast without throwing an exception if the cast is invalid.
// Can only be used with reference types (objects, arrays, etc.) or nullable types.
// Returns null if the cast is not successful.

// Comparison with Casting:
//is:

// Purpose: Type checking. It's not a casting operator, but you can use it in combination with casting ((type)) to
// ensure that the cast will succeed.
// Example: Use is for type checking before casting.

//as:
// Purpose: Safe casting (only with reference types or nullable types). It returns null if the cast fails, instead
// of throwing an exception.
//Example: Use as for a safe attempt at casting without throwing an exception.
//When to Use is vs as

//is:
// Use it when you need to check the type of an object before deciding whether to perform the cast.

//as:
// Use it when you want to perform a safe cast, where an invalid cast would return null rather than
// throwing an exception.
public static class IS_And_As
{
    public static void Check()
    {
        object obj = "Hello, World!";

// Using 'is'
        if (obj is string)
        {
            string str = (string)obj; // Safe cast after checking
            Console.WriteLine(str); // Output: Hello, World!
        }

// Using 'as'
        string str2 = obj as string; // Safe cast using 'as'
        if (str2 != null)
        {
            Console.WriteLine(str2); // Output: Hello, World!
        }
        else
        {
            Console.WriteLine("Cast failed");
        }
    }
}
namespace CommonOOPConcepts;

public class Configuration
{
    private static readonly int MaxConnections; // Set once, never changes
    private static int ActiveConnections; // Can change dynamically

    static Configuration()
    {
        MaxConnections = 100; // Initialized once
        ActiveConnections = 0; // Initial value
    }

    public static void Connect()
    {
        if (ActiveConnections < MaxConnections)
        {
            ActiveConnections++;
            Console.WriteLine($"Connected. Active: {ActiveConnections}");
        }
        else
        {
            Console.WriteLine("Max connections reached.");
        }
    }
}

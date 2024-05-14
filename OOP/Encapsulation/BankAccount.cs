namespace Encapsulation;


//Encapsulation is one of the fundamental principles of object-oriented programming (OOP) that helps in hiding the
//internal implementation details of an object and exposing only what is necessary. In C#, encapsulation is achieved
//through the use of access modifiers like private, protected, internal, and public, along with properties and methods.
public class BankAccount
{
    // Private fields to store account details
    private string accountHolder;
    private double balance;

    // Public property to get and set the account holder name
    public string AccountHolder
    {
        get { return accountHolder; }
        set
        {
            // Validation can be added here
            if (!string.IsNullOrEmpty(value))
            {
                accountHolder = value;
            }
            else
            {
                Console.WriteLine("Account holder name cannot be empty.");
            }
        }
    }

    // Public method to deposit money into the account
    public void Deposit(double amount)
    {
        // Validation can be added here
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount:C} deposited successfully. Current balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Public method to withdraw money from the account
    public void Withdraw(double amount)
    {
        // Validation can be added here
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn successfully. Current balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

    // Public method to get the current balance
    public double GetBalance()
    {
        return balance;
    }
}
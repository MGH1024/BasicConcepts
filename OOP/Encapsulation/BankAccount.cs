namespace Encapsulation;


//Encapsulation is one of the fundamental principles of object-oriented programming (OOP) that helps in hiding the
//internal implementation details of an object and exposing only what is necessary. In C#, encapsulation is achieved
//through the use of access modifiers like private, protected, internal, and public, along with properties and methods.
public class BankAccount
{
    // Private fields to store account details
    private  string _accountHolder;
    private double _balance;

    // Public property to get and set the account holder name
    public string AccountHolder
    {
        get => _accountHolder;
        set
        {
            // Validation can be added here
            if (!string.IsNullOrEmpty(value))
            {
                _accountHolder = value;
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
            _balance += amount;
            Console.WriteLine($"{amount:C} deposited successfully. Current balance: {_balance:C}");
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
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"{amount:C} withdrawn successfully. Current balance: {_balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

    // Public method to get the current balance
    public double GetBalance()
    {
        return _balance;
    }
}
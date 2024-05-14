using Encapsulation;

BankAccount myAccount = new BankAccount();

// Set the account holder name using the property
myAccount.AccountHolder = "John Doe";

// Deposit and withdraw money using methods
myAccount.Deposit(1000);
myAccount.Withdraw(500);

// Get and display the current balance
double currentBalance = myAccount.GetBalance();
Console.WriteLine($"Current balance for {myAccount.AccountHolder}: {currentBalance:C}");
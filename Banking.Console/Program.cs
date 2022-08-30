int AccountId = 0;
int AccountBalance = 0;

Random random = new Random();
AccountBalance = random.Next(1,50000);

//Welcome and account info
Console.WriteLine("Welcome to Thrys Banking");
Console.WriteLine("Your account number is: " + AccountId);
Console.WriteLine("Your current balance is: " + AccountBalance);
Console.ReadKey();


Console.WriteLine("Please select an option");
Console.WriteLine("1: Insert money");
Console.WriteLine("2: Withdrawal money");

//Check input
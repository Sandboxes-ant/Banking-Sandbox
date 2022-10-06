uint accountId = 25;
int accountBalance = 0;
int input = 0;
int amountOfMoney = 0;

Random random = new Random();
accountBalance = random.Next(1, 50000);


//Welcome and account info
Console.WriteLine("Welcome to Thrys Banking");
Console.WriteLine("Your account number is: " + accountId);
Console.WriteLine("Your current balance is: " + accountBalance);
Console.WriteLine("Please press any buttom to continue");
Console.ReadKey();

Console.WriteLine("Please select an option");
Console.WriteLine("1: Insert money");
Console.WriteLine("2: Withdrawal money");

input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case < 0:
        Environment.Exit(0);
        break;
    
    case 1:
        Console.WriteLine("You have selected to insert money");
        Console.WriteLine("How much money would you like to insert?");
        amountOfMoney = Convert.ToInt32(Console.ReadLine());
        accountBalance = accountBalance + amountOfMoney;
        Console.WriteLine("Your total balance is now: " + accountBalance);
        Console.WriteLine("Bye!");
        Console.ReadKey();
        Environment.Exit(0);
        break;
    
    case 2:
        Console.WriteLine("You have selected to withdraw money");
        Console.WriteLine("How much money would you like to withdraw?");
        Console.WriteLine("Your balance is: " + accountBalance);
        amountOfMoney = Convert.ToInt32(Console.ReadLine());
        accountBalance = accountBalance - amountOfMoney;

        if (accountBalance <= 0)
        {
            Console.WriteLine("You cannot withdraw more money than you own!");
            Console.WriteLine("Bye!");
            Console.ReadKey();
            Environment.Exit(0);
        }

        else
        {
            Console.WriteLine("You have withdrawed: " + amountOfMoney);
            Console.WriteLine("Your new balance is: " + accountBalance);
            Console.WriteLine("Bye!");
            Console.ReadKey();
            Environment.Exit(0);

        }
        break;
    
    case > 2:
        Console.Write("Error :-) Function not added yet!");
        Console.ReadKey();
        Environment.Exit(0);
        break;
}

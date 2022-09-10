int AccountId = 0;
int AccountBalance = 0;
int Input = 0;
int AmountOfMoney = 0;

Random random = new Random();
AccountBalance = random.Next(1, 50000);

Random random2 = new Random();
AccountId = random2.Next(1, 10);

//Welcome and account info
Console.WriteLine("Welcome to Thrys Banking");
Console.WriteLine("Your account number is: " + AccountId);
Console.WriteLine("Your current balance is: " + AccountBalance);
Console.WriteLine("Please press any buttom to continue");
Console.ReadKey();

Console.WriteLine("Please select an option");
Console.WriteLine("1: Insert money");
Console.WriteLine("2: Withdrawal money");

Input = Convert.ToInt32(Console.ReadLine());

if (Input == 1)
{
    Console.WriteLine("You have selected to insert money");
    Console.WriteLine("How much money would you like to insert?");
    AmountOfMoney = Convert.ToInt32(Console.ReadLine());
    AccountBalance = AccountBalance + AmountOfMoney;
    Console.WriteLine("Your total balance is now: " + AccountBalance);
    Console.WriteLine("Bye!");
    Console.ReadKey();
    Environment.Exit(0);
}

if (Input == 2)
{
    Console.WriteLine("You have selected to withdraw money");
    Console.WriteLine("How much money would you like to withdraw?");
    Console.WriteLine("Your balance is: " + AccountBalance);
    AmountOfMoney = Convert.ToInt32(Console.ReadLine());
    AccountBalance = AccountBalance - AmountOfMoney;

    if (AccountBalance <= 0)
    {
        Console.WriteLine("You cannot withdraw more money than you own!");
        Console.WriteLine("Bye!");
        Console.ReadKey();
        Environment.Exit(0);
    }

    else
    {
        Console.WriteLine("You have withdrawed: " + AmountOfMoney);
        Console.WriteLine("Your new balance is: " + AccountBalance);
        Console.WriteLine("Bye!");
        Console.ReadKey();
        Environment.Exit(0);
    }

}

else
{
    Console.Write("Error :-) Function not added yet!");
    Console.ReadKey();
}
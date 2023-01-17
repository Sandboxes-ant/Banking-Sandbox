interface IAccount
{
    void getId();
    void getBalance();
    void getMoney();
}

class Account : IAccount
{
    public void getId()
    {
        uint accountNumber = 25;
        Console.WriteLine("Your account number is: " + accountNumber);
    }

    public void getBalance()
    {
        uint accountBalance = 42069;
        Console.WriteLine("Your balance is: " + accountBalance);
    }

    public void getMoney()
    {
        int amountOfMoney = 0;
        Console.WriteLine("How much money would you like to withdraw?");
        amountOfMoney = Convert.ToInt32(Console.ReadLine());
    }
}

class Program
{
    static void Main(string[] args)
    {
        int input = 0;
        Account myAccount = new Account();

        Console.WriteLine("Welcome to Thrys Banking");
        Console.WriteLine("Please select an option");
        Console.WriteLine("1: Get bank account information");
        Console.WriteLine("1: Insert money");
        Console.WriteLine("2: Withdrawal money");

        input = Convert.ToInt32(Console.ReadLine());

        switch(input)
        {
            case < 0:
                Environment.Exit(0);
                break;

            case 1:
                myAccount.getId();
                myAccount.getBalance();
                Console.ReadKey();
                break;


        }
    }
}
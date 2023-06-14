namespace ATM
{
    public class Program
    {
        public static decimal Balance = 0;
        static void Main(string[] args)
        {
            UserInterface();
        }
        public static decimal ViewBalance()
        {
            return Balance;
        }
        public static decimal Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"You can't withdraw {amount} because it's greater then your balance {Balance}");
                return Balance;
            }
            else if (amount < 0)
            {
                Console.WriteLine($"You cant withdraw {amount} it's less than 0!!!!!!");
                return Balance;
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"You have successfully withdrawn {amount}$ from your Balance");
            }

            return Balance;
        }

        public static decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine($"You cant deposite negative number {amount} ");
                return Balance;
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"You have successfully deposited {amount}$ into your balance");
            }
            return Balance;
        }

        public static void UserInterface()
        {
            Console.WriteLine("Hello");
            string choice;
            do
            {
                Console.WriteLine("please Choose an option:");
                Console.WriteLine("1. Withdraw Money");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. View Balance");
                Console.WriteLine("4. Exit");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        Console.WriteLine("Please enter the amount you want to withdraw from your balance:");
                        decimal Wamount = Convert.ToDecimal(Console.ReadLine());
                        decimal newBalanceW = Withdraw(Wamount);
                        Console.WriteLine($"Your Balance now = {newBalanceW}$");

                        break;
                    case "2":
                        Console.WriteLine("Please select the amount you want to deposit into your balance:");
                        decimal Damount = Convert.ToDecimal(Console.ReadLine());
                        decimal newBalanceD = Deposit(Damount);
                        Console.WriteLine($"Your balance now ={newBalanceD}$ ");
                        break;

                    case "3":
                        Console.WriteLine($"Your Balance = {Balance}$");
                        break;
                    case "4":
                        Console.WriteLine("Thank You bye bye ...");
                        break;

                    default:
                        Console.WriteLine("Error try again");
                        break;


                }
            } while (choice != "4");

        }

    }
}
class Restaurant
{
    static void Main()
    {
        string predefinedPhone = "9311157708";
        string predefinedEmail = "user@email.com";
        string predefinedOTP = "123456";


        bool isLoggedIn = false;
        while (!isLoggedIn)
        {
            Console.WriteLine("----LOGIN----");
            Console.Write("Enter Phone number: ");
            string phoneInput = Console.ReadLine() ?? "";

            Console.Write("Enter Email ID: ");
            string emailInput = Console.ReadLine() ?? "";

            Console.Write("Enter OTP: ");
            string otpInput = Console.ReadLine() ?? "";

            if (phoneInput == predefinedPhone && emailInput == predefinedEmail && otpInput == predefinedOTP)
            {
                Console.WriteLine("\nLogin Successful!\n");
                isLoggedIn = true;
            }
            else
            {
                Console.WriteLine("Login Failed. Please check credentials.\n");
            }
        }

        int choice;
        int quantity;
        double totalbill = 0;


        List<string> items = new List<string>();
        List<int> quantities = new List<int>();
        List<int> prices = new List<int>();
        List<int> totals = new List<int>();

        do
        {
            System.Console.WriteLine("\nWelcome");
            System.Console.WriteLine("\n1. Burger - 100Rs");
            System.Console.WriteLine("2. Pizza - 200Rs");
            System.Console.WriteLine("3. Pasta - 150Rs");
            System.Console.WriteLine("4. Coffee - 80Rs");
            System.Console.WriteLine("5. Exit");

            System.Console.Write("\nEnter your choice = ");
            choice = Convert.ToInt32(System.Console.ReadLine());

            switch (choice)
            {
                case 1:
                    System.Console.Write("Enter quantity of Burgers: ");
                    quantity = Convert.ToInt32(System.Console.ReadLine());
                    items.Add("Burger");
                    quantities.Add(quantity);
                    prices.Add(100);
                    totals.Add(100 * quantity);
                    totalbill += 100 * quantity;
                    break;

                case 2:
                    Console.Write("Enter quantity of Pizzas: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    items.Add("Pizza");
                    quantities.Add(quantity);
                    prices.Add(200);
                    totals.Add(200 * quantity);
                    totalbill += 200 * quantity;
                    break;

                case 3:
                    Console.Write("Enter quantity of Pasta: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    items.Add("Pasta");
                    quantities.Add(quantity);
                    prices.Add(150);
                    totals.Add(150 * quantity);
                    totalbill += 150 * quantity;
                    break;

                case 4:
                    Console.Write("Enter quantity of Coffee: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    items.Add("Coffee");
                    quantities.Add(quantity);
                    prices.Add(80);
                    totals.Add(80 * quantity);
                    totalbill += 80 * quantity;
                    break;

                case 5:
                    Console.Write("\nAre you sure you want to exit? (yes/no): ");
                    string confirm = System.Console.ReadLine() ?? "no";

                    if (confirm.ToLower() == "yes")
                    {
                        Console.WriteLine(" ");

                        Console.WriteLine("Item\t\tQuantity\tPricePerQuantity\tTotalPrice");

                        for (int i = 0; i < items.Count; i++)
                        {
                            Console.WriteLine($"{items[i],-10}\t{quantities[i],-8}\t{prices[i],-16}\t{totals[i]}");
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("\nTotal Price:\t\t\t\t\t" + totalbill);
                        Console.WriteLine(" ");
                        Console.WriteLine("Thank you for visiting!");
                    }
                    else
                    {
                        Console.WriteLine("\nGreat choice! Let’s continue ordering...\n");
                        choice = 0;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }

        } while (choice != 5);
    }
}

internal class Program
{
    static void Toko()
    {
        Console.WriteLine("WELCOME TO THE FRUIT MART");
        Console.WriteLine();
        Console.WriteLine("What can i help you?\n[1] Buy\n[2] View Cart\n[3] Edit Cart\n[4] Checkout");
    }
    static void Menu()
    {
        Console.WriteLine("|-----------------------------|");
        Console.WriteLine("|	   ITEM LIST	      |");
        Console.WriteLine("|-----------------------------|");
        Console.WriteLine("| ID   |    Item  |   Price   |");
        Console.WriteLine("|-----------------------------|");
        Console.WriteLine("|  1   |   Apple  |     $1    |");
        Console.WriteLine("|  2   |   Orange |     $2    |");
        Console.WriteLine("|  3   |   Lychee |     $6    |");
        Console.WriteLine("|  4   |   Banana |     $5    |");
        Console.WriteLine("|  5   |   Durian |    $12    |");
        Console.WriteLine("|  6   |   Lemon  |     $3    |");
        Console.WriteLine("|-----------------------------|");
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        Toko();
        Console.Write("Choose: ");
        int choose = Convert.ToInt32(Console.ReadLine());
        int Quantity = 0;
        string Item = " ";
        int ID = 0;
        string More = "y";
        int cart = 0;
        Console.WriteLine();
        if (choose == 1 && cart == 0)
        {
            Menu();
            while (choose < 0 && choose > 5)
            {
                Console.WriteLine("Invalid Menu");
                Toko();
            }
            while (More == "y")
            {
                while (ID < 1 || ID > 6)
                {
                    Console.Write("Enter Item ID: ");
                    ID = Convert.ToInt32(Console.ReadLine());
                    if (ID < 1 || ID > 6)
                    {
                        Console.WriteLine("Invalid Item");
                        Console.Write("Enter Item ID: ");
                        ID = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Write("Enter Quantity:");
                    Quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    if (ID == 1)
                    {
                        Item = "Apple";
                        Console.WriteLine("Bought " + Quantity + " pcs of " + Item);
                    }
                    else if (ID == 2)
                    {
                        Item = "Orange";
                        Console.WriteLine("Bought " + Quantity + " pcs of " + Item);
                    }
                    else if (ID == 3)
                    {
                        Item = "Lychee";
                        Console.WriteLine("Bought " + Quantity + " pcs of " + Item);
                    }
                    else if (ID == 4)
                    {
                        Item = "Banana";
                        Console.WriteLine("Bought " + Quantity + " pcs of " + Item);
                    }
                    else if (ID == 5)
                    {
                        Item = "Durian";
                        Console.WriteLine("Bought " + Quantity + " pcs of " + Item);
                    }
                    else if (ID == 6)
                    {
                        Item = "Lemon";
                        Console.WriteLine("Bought " + Quantity + " pcs of " + Item);
                    }

                    Console.WriteLine("Buy More item? (y/n) ");
                    More = Console.ReadLine();
                }

            }
            
        }
        Toko();
        Console.Write("Choose: ");
        choose = Convert.ToInt32(Console.ReadLine());
        if (choose == 2 && cart == 0)
        {
            Console.WriteLine("CART\n\nCart is empty");
        }
        if (choose == 2 && cart == 1)
        {

        }
    }
}

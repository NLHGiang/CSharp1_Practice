namespace MyWorks.CSharp1.Lab345678
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create furnitures
            Computer computer = new Computer(2, 1, 2);
            Table table = new Table(2, 2, 2);
            Chair chair = new Chair(1, 1, 1);
            Wardrobe wardrobe = new Wardrobe(2, 1, 3);
            Bed bed = new Bed(1.5f, 2, 1);

            // Create custom 1
            Customer customer1 = new Customer("Nguyen A", 20, "Ha Noi", "0123456789");
            customer1.InsertFurniture(computer);
            customer1.InsertFurniture(computer);
            customer1.InsertFurniture(computer);
            customer1.InsertFurniture(table);

            // Create custom 2
            Customer customer2 = new Customer("Nguyen B", 22, "Hai Phong", "0789456123");
            customer2.InsertFurniture(wardrobe);
            customer2.InsertFurniture(wardrobe);
            customer2.InsertFurniture(wardrobe);
            customer2.InsertFurniture(bed);

            // Create custom 3
            Customer customer3 = new Customer("Nguyen C", 23, "Ha Noi", "0456789123");
            customer3.InsertFurniture(computer);
            customer3.InsertFurniture(table);
            customer3.InsertFurniture(chair);
            customer3.InsertFurniture(wardrobe);
            customer3.InsertFurniture(bed);

            // Create Company
            MovingCompany company = new MovingCompany("A-Z");
            company.InsertCustomer(customer1);
            company.InsertCustomer(customer2);

            do
            {
                Menu();
                Console.WriteLine("<?> Enter your choice");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        company.InsertCustomer(customer3);
                        break;
                    case "2":
                        company.DeleteCustomer();
                        break;
                    case "3":
                        Console.Write("Enter the customer's name you want to delete: ");
                        string nameDelete = Console.ReadLine();
                        company.DeleteCustomer(nameDelete);
                        break;
                    case "4":
                        company.CheckValidVolume();
                        break;
                    case "5":
                        company.OutputInformationOfCompany();
                        break;
                    case "6":
                        company.OutputInformationOfCustomers();
                        break;
                    case "0":
                        Console.WriteLine("EXITED !!!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice(0-6) !");
                        break;
                }
            } while (true);
        }

        // List of functions
        static void Menu()
        {
            Console.WriteLine("=============MENU=============");
            Console.WriteLine("| 1. Insert Customer          |");
            Console.WriteLine("| 2. Delete Customer          |");
            Console.WriteLine("| 3. Delete Customer By Name  |");
            Console.WriteLine("| 4. Check Customer           |");
            Console.WriteLine("| 5. Company Information      |");
            Console.WriteLine("| 6. Customers Information    |");
            Console.WriteLine("| 0. Exit                     |");
            Console.WriteLine("==============================");
        }
    }
}
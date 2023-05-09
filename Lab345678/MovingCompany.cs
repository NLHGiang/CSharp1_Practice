using System.Collections;

namespace MyWorks.CSharp1.Lab345678
{
    internal class MovingCompany
    {
        private string name;

        private ArrayList customers = new ArrayList();

        public MovingCompany()
        {
            this.name = "???";
        }

        public MovingCompany(string name)
        {
            this.name = name;
        }

        public void InsertCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void DeleteCustomer()
        {
            int position;
            if (customers.Count == 0)
            {
                Console.WriteLine("There is no customer here !");
            }
            else
            {
                Console.WriteLine("<?>What is the position of the customer you want to delete ?");
                position = Convert.ToInt32(Console.ReadLine());

                if (position > 0 && (position-1) < customers.Count)
                {
                    customers.RemoveAt(position-1);
                    Console.WriteLine("_Deleted the customer_");
                }
                else
                {
                    Console.WriteLine("Invalid position !");
                }
            }
        }

        public void DeleteCustomer(string name)
        {
            int count = 0;

            for (int i = 0; i < customers.Count; )
            {
                Customer customer = new Customer();
                customer=(Customer)customers[i];

                if (customer.GetName() == name)
                {
                    customers.Remove(customers[i]);
                    Console.WriteLine("_Deleted the customer_");
                    count++;
                }
                else
                {
                    i++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine($"There is no customer having the name as \"{name}\"");
            }
        }

        public void CheckValidVolume()
        {
            // const volumnMax
            const float volumeMax = 10;

            if (customers.Count == 0)
            {
                Console.WriteLine("There is no customer here !");
            }
            else
            {
                int count = 1;

                foreach (Customer customer in customers)
                {
                    Console.WriteLine($"*Customer {count}:");

                    float volumeTotal = customer.TotalVolume();

                    Console.WriteLine($"Total volume = {volumeTotal}");

                    if (volumeTotal > volumeMax)
                    {
                        Console.WriteLine("Invalid Volume !!!");
                    }
                    else
                    {
                        Console.WriteLine("Valid Volume !!!");
                    }
                    Console.WriteLine();
                    count++;
                }
            }
        }

        public void OutputInformationOfCompany()
        {
            Console.WriteLine($"The company's name: {this.name}");
            Console.WriteLine($"The number of customers: {this.customers.Count}");
        }

        public void OutputInformationOfCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("There is no customer here !");
            }
            else
            {
                int count = 1;
                foreach (Customer customer in customers)
                {
                    Console.WriteLine($"*Customer {count}:");
                    customer.OutputInformationOfCustomer();
                    Console.WriteLine();

                    count++;
                }
            }
        }

    }
}

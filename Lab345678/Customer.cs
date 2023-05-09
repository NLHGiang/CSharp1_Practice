using System.Collections;

namespace MyWorks.CSharp1.Lab345678
{
    internal class Customer
    {
        protected string name;
        protected int age;
        private string address;
        private string phonenumber;

        public ArrayList furnitures = new ArrayList();

        public Customer()
        {
            this.name = "? ? ?";
            this.age = -1;
            this.address = "? ? ?";
            this.phonenumber = "? ? ?";
        }

        public Customer(string name, int age, string address, string phonenumber)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.phonenumber = phonenumber;
        }

        public void InsertFurniture(dynamic x)
        {
            furnitures.Add(x);
        }

        public void DeleteFurniture()
        {
            int position;
            if (furnitures.Count == 0)
            {
                Console.WriteLine("There is no furniture here !");
            }
            else
            {
                do
                {
                    Console.WriteLine("<?>What is the position of the funiture you want to delete ?");

                    position = Convert.ToInt32(Console.ReadLine());

                    if (position < furnitures.Count)
                    {
                        furnitures.RemoveAt(position);
                        Console.WriteLine("_Deleted the funiture_");
                    }
                    else
                    {
                        Console.WriteLine("Invalid position !");
                    }
                } while (position >= furnitures.Count);
            }
        }

        public void OutputInformationOfCustomer()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Phonenumber: {phonenumber}");
            Console.WriteLine($"Number of furnitures: {furnitures.Count}");
        }

        public float TotalVolume()
        {
            float volumeSum = 0;

            // var => ngầm hiểu kiểu dữ liệu

            foreach (dynamic x in furnitures)
            {
                volumeSum += x.GetVolume();
            }

            return volumeSum;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}

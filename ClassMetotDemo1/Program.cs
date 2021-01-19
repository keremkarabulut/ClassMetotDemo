using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 101;
            customer1.CustomerName = "Doğan";
            customer1.CustomerSurname = "ÖZYURT";
            customer1.Asset = 255958.55;

            Customer customer2 = new Customer();
            customer2.Id = 102;
            customer2.CustomerName = "Enes";
            customer2.CustomerSurname = "ÖZER";
            customer2.Asset = 458373.79;

            Customer customer3 = new Customer();
            customer3.Id = 103;
            customer3.CustomerName = "Doğuş";
            customer3.CustomerSurname = "ÖZYURT";
            customer3.Asset = 101222.10;

            Customer customer4 = new Customer();
            customer4.Id = 104;
            customer4.CustomerName = "Barış";
            customer4.CustomerSurname = "KARABULUT";
            customer4.Asset = 758292.21;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(customer1);
            Console.WriteLine("\n ------------------- \n");

            musteriManager.Listing(customers);
            Console.WriteLine("\n ------------------- \n");

            musteriManager.Deletion(customer1);
        }
    }
}
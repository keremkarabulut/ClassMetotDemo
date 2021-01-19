using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Ekleniyor... \n" + customer.Id + " Nolu " + customer.CustomerName + " " + customer.CustomerSurname + "\nMüşteri Eklendi.");
        }
        public void Listing(params Customer[] customers)
        {
            Console.WriteLine("Müşteriler Listeleniyor... Lütfen Bekleyeniz.");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " Nolu " + customer.CustomerName + " " + customer.CustomerSurname + "\n" + "Toplam Varlık: " + customer.Asset + " TL" + "\n");
            }
            Console.WriteLine("Müşteriler Başarılı Bir Şekilde Listelendi.");
        }
        public void Deletion(Customer customer)
        {
            Console.WriteLine("Müşteri Silme İşlemi Gerçekleştiriliyor... \n" + customer.Id + " Nolu " + customer.CustomerName + " " + customer.CustomerSurname + "\n" + "Müşteri Silme İşlemi Başarılı Bir Şekilde Tamamlandı.");
        }
    }
}
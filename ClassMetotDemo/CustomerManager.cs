using System;
namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {

            Console.WriteLine("Yeni müşteri başarıyla eklendi!{0}", customer.customerName);
        }
        public void DeleteCustomer(Customer customer)
        {

            Console.WriteLine("Müşteri silindi!");
        }
        public void UpdateCustomer(Customer customer)
        {

            Console.WriteLine("Müşteri bilgileri güncellendi!");

        }
        public void ShowCustomers(Customer[] customers)
        {

            Console.WriteLine("---------    MÜŞTERİLER  ---------");
            foreach (Customer c in customers)
            {
                Console.WriteLine("İsim: {0}, Soyisim: {1}", c.customerName, c.customerSurname);

            }
        }
    }
}

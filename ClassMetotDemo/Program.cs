using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customerName = "Ali";
            customer1.customerSurname = "ASAF";
            customer1.customerAge = 36;
            customer1.isActive = false;

            Customer customer2 = new Customer();
            customer2.customerName = "Falih";
            customer2.customerSurname = "RIFKI";
            customer2.customerAge = 45;
            customer2.isActive = true;

            Customer customer3 = new Customer();
            customer3.customerName = "Zeynep";
            customer3.customerSurname = "BASTIK";
            customer3.customerAge = 25;
            customer3.isActive = true;

            Customer customer4 = new Customer();
            customer4.customerName = "Sherlock";
            customer4.customerSurname = "HOLMES";
            customer4.customerAge = 55;
            customer4.isActive = false;

            Customer customer5 = new Customer();
            customer5.customerName = "Nazım";
            customer5.customerSurname = "HİKMET";
            customer5.customerAge = 18;
            customer5.isActive = true;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };


            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            customerManager.UpdateCustomer(customer3);
            customerManager.AddCustomer(customer4);
            customerManager.DeleteCustomer(customer2);
            customerManager.ShowCustomers(customers);

        }
    }
}

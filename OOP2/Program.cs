using System;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNum = "15256";
            customer1.FirstName = "Ali";
            customer1.LastName = "Demir";
            customer1.IdentityNum = "14775326985";

            ProCustomer customer2=new ProCustomer();
            customer2.Id = 2;
            customer2.CustomerNum = "24115";
            customer2.CompanyName = "CodeX";
            customer2.TaxNumber = "1254869872";

            Customer customer3=new RealCustomer();
            Customer customer4=new ProCustomer();

            CustomerManager customerManager=new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
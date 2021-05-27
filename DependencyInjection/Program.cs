using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Kemal";
            customer1.LastName = "Atatürk";

            //Database Log                     you can change    (new FileLogger());
            CustomerManager customerManager = new CustomerManager(new DatabaseLogger());
            customerManager.AddCustomer(customer1);

        }
    }
}

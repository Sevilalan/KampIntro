using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            PruductManager pruductManager = new PruductManager();
            pruductManager.Add();
            pruductManager.Update();
            

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
              Id=2, City="İstanbul", FirstName="Derin", LastName="Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);






            Console.ReadLine();

        }
    } 
}

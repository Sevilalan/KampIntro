using System;

namespace Cunstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirsName = "Engin", LastName = "Demiroğ", City = "Ankara" };
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Console.WriteLine(customer2.FirsName+customer2.City+customer2.LastName+customer2.Id);
            Console.WriteLine(customer1.Id);

        }
    }
    class Customer
    {
        public Customer()
        {

        }
        //default constructur yazsak da yazmasakda arka planda çalışır aslında 
        public Customer(int id, string firstName, string lastName, string city)
        {
            FirsName = firstName;
            Id = id;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}

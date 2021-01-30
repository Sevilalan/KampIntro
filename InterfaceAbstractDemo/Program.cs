using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstract.BaseCustomerManager customerManager = new Concrete.StarbucksCustomerManager(new Adapters.MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateofBirt=new DateTime(1985,1,6), FirstName="Engin",LastName="Demiroğ", NationalityId="123456"});
            Console.ReadLine();
        }
    }
}

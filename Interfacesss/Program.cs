using System;

namespace Interfacesss
{
    class Program
    {
        //interfaceler newlenemezler!
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
           
            //IPersonManager employeManager = new EmployeManager();
           

            ProjectManager projectManager = new ProjectManager();
            //projectManager.Add(employeManager);
            projectManager.Add(new InternManager());
   
        }
    }
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
        
    }
    //inherits-class-------------------implements-interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("personel güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("stajer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("stajer güncellendi");
        }
    }
    class ProjectManager
    {
 public void Add(IPersonManager personManager)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            personManager.Add();
            //personManager.Update();
        }

       
    }
}

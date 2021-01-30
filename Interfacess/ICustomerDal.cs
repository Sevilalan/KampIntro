using System;
using System.Collections.Generic;
using System.Text;

namespace Interfacess
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("oracle updated");
        }
    }
    class Mysql : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}

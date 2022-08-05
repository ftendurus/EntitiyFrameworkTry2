using Business;
using DataAccess;
using System;

namespace EntitiyFrameworkTry2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine("{0} / {1}",customer.CustomerID,customer.CompanyName);
            }
        }
    }
}

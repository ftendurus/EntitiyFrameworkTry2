using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EfCustomerDal : ICustomerDal
    {
        public List<Customer> GetAll()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Customers.ToList();
            }
        }

        public Customer GetById(string id)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                return context.Customers.SingleOrDefault(p=>p.CustomerID == id);
            }
        }
    }
}

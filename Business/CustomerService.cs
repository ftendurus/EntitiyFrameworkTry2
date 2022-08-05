using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface CustomerService
    {
        List<Customer> GetAll();
        Customer GetById(string id);
    }
}

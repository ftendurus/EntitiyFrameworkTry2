using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer:IEntity
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
    }
}

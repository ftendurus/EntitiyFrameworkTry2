using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll();
        T GetById(string id);
    }
}

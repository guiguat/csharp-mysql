using csharp_mysql.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_mysql.Controllers
{
    interface IController<T>
    {
        IEnumerable<T> List();
        void Insert(T t);
        void Put(T t);
        void Delete(int id);
    }
}

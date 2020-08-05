using csharp_mysql.Database;
using csharp_mysql.Models;
using System;
using System.Collections.Generic;

namespace csharp_mysql.Controllers
{
    class StudentController : IController<Student>
    {
        public IEnumerable<Student> List()
        {
            throw new NotImplementedException();
        }
        public void Insert(Student s)
        {
            try
            {
                string query = $"INSERT INTO Student(id, name, class) VALUES ({s.Id}, '{s.Name}', '{s.Class}')";
                Db inst = Db.GetInstance();
                inst.Execute(inst.GetConnection(), query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Put(Student s)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

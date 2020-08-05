using System;
using System.Collections.Generic;
using System.Text;
namespace csharp_mysql.Models
{
    class Student
    {
        public Student(int id, string name, string student_class)
        {
            this.Id = id;
            this.Class = student_class;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
    }
}

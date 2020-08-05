using csharp_mysql.Database;
using csharp_mysql.Models;
using System;
using System.Collections.Generic;

namespace csharp_mysql.Controllers
{
    class LectureController : IController<Lecture>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
            
        public void Insert(Lecture l)
        {
            try
            {
                string query = "INSERT INTO Lectures(title, speaker_name, day, hour) " +
                    $"VALUES ('{l.Title}', '{l.SpeakerName}', '{l.Day}', '{l.Hour}')";
                Db inst = Db.GetInstance();
                inst.Execute(inst.GetConnection(), query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Lecture> List()
        {
            throw new NotImplementedException();
        }

        public void Put(Lecture l)
        {
            throw new NotImplementedException();
        }
    }
}

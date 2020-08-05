using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_mysql.Models
{
    class Lecture
    {
        public Lecture(int id = 0, string title, string speaker, string day, string hour)
        {
            this.Id = id;
            this.Title = title;
            this.SpeakerName = speaker;
            this.Day = day;
            this.Hour = hour;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string SpeakerName { get; set; }
        public string Day { get; set; }
        public string Hour { get; set; }
    }
}

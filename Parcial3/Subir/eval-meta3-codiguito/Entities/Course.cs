using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUCA.Entities
{
    public class Course
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;
        private string text6;

        public Course(string Title, int Modules, string Topic, string Author, int Duration, string Schedule)
        {
            this.Title = Title;
            this.Modules = Modules;
            this.Topic = Topic;
            this.Author = Author;
            this.Duration = Duration;
            this.Schedule = Schedule;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int Modules{ get; set; }

        public string Topic { get; set; }

        public string Author { get; set; }

        public int Duration { get; set; }

        public string Schedule { get; set; }
    }
}

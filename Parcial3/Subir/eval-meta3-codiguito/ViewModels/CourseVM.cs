using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUCA.ViewModels
{
   public class CourseVM
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Modules { get; set; }

        public string Topic { get; set; }

        public string Author { get; set; }

        public int Duration { get; set; }

        public string Schedule { get; set; }
    }
}

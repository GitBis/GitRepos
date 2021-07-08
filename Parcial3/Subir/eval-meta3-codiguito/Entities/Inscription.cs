using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUCA.Entities
{
    public class Inscription
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;

        public Inscription(string FullName, string Email, string PhoneNumber, int IdCourse)
        {
            this.FullName = FullName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.IdCourse = IdCourse;
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Course Course { get; set; }

        public int IdCourse { get; set; }

        public int IdUser { get; set; }

        public virtual Course IdCourseNavigation { get; set; }

        public virtual Enrollment IdUserNavigation { get; set; }
    }
}

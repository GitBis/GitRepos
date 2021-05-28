using Microsoft.VisualBasic;

namespace Parcial2.Model
{
    public class Reservation
    {
        public int id { get; set; }
        public User user { get; set; }
        public Speciality speciality { get; set; }
        public DateFormat dateTime { get; set; }

        public Reservation()
        {
            
        }

        public Reservation(int id, User user, Speciality speciality, DateFormat dateTime)
        {
            this.id = id;
            this.user = user;
            this.speciality = speciality;
            this.dateTime = dateTime;
        }
    }
}
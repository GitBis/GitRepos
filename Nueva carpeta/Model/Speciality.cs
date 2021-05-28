namespace Parcial2.Model
{
    public class Speciality
    {
        public int id { get; set; }
        public string especiality { get; set; }

        public Speciality()
        {
            
        }

        public Speciality(int id, string especiality)
        {
            this.id = id;
            this.especiality = especiality;
        }
    }
}
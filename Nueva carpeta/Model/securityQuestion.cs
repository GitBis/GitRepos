using Microsoft.VisualBasic;

namespace Parcial2.Model
{
    public class securityQuestion
    {
        public int id { get; set; }
        public string questions { get; set; }

        public securityQuestion()
        {
            
        }

        public securityQuestion(int id, string questions)
        {
            this.id = id;
            this.questions = questions;
        }
    }
}
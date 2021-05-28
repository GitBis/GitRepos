/* Usuario: contiene los siguientes campos.
 
Carné (llave primaria).
Nombre completo.
Contraseña.
Referencia a la pregunta de seguridad (llave foránea).
Respuesta a la pregunta de seguridad.
*/

using System.Collections.Generic;

namespace Parcial2.Model

{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public List<securityQuestion> questions { get; set; }
        public string answer { get; set; }

        public User()
        {
            
        }

        public User(int id, string name, string password, List<securityQuestion> questions, string answer)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.questions = questions;
            this.answer = answer;
        }


    }
}
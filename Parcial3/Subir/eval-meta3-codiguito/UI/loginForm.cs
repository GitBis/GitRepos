using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUCA.Context;

namespace AppUCA.UI
{
    public partial class loginForm : Form
    {
        public bool IsLogged { get; set; }

        public loginForm()
        {
            InitializeComponent();
            IsLogged = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var db = new AppGuiContext();
            var uss = db.Enrollments.ToList();
            var result = uss.Where(
                f => f.Userr.Equals(emailTxt.Text)
            ).ToList();

            if (result.Count == 0)
            {

                MessageBox.Show("Usuario o contrasena incorrecta.", "Ingreso fallido",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                               
            }
            else
            {
                
                this.IsLogged = true;
                MessageBox.Show("Bienvenido");
                this.Close();
                
            }
{}
   


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

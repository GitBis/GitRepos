using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppUCA.Entities;

namespace AppUCA.ViewModels
{
    public class InscriptionVM
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Course Course { get; set; }

        public int IdCourse { get; set; }

        public int IdUser { get; set; }
    }
}

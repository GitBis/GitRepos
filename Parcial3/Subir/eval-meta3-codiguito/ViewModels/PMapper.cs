using AppUCA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUCA.ViewModels
{
    public static class PMapper
    {
        public static CourseVM MapCourseToCourseVM(Course c)
        {
            return new CourseVM
            {
                Id = c.Id,
                Title = c.Title,
                Modules = c.Modules,
                Topic = c.Topic,
                Author = c.Author,
                Duration = c.Duration,
                Schedule = c.Schedule,
            };
        }
        public static InscriptionVM MapInscriptionToInscriptionVM(Inscription i)
        {
            return new InscriptionVM
            {
                Id = i.Id,
                FullName = i.FullName,
                Email = i.Email,
                PhoneNumber = i.PhoneNumber,
                Course = i.Course,
                IdCourse = i.IdCourse,
                IdUser = i.IdUser,
            };
        }
    }
}

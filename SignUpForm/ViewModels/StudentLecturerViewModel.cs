using SignUpForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpForm.ViewModels
{
    public class StudentLecturerViewModel
    {
        public Student Student { get; set; }
        public List<Lecturer> Lecturers { get; set; }
    }
}

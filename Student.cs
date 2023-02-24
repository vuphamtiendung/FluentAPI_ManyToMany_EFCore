using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI_ManyToMany_003
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        
        public IList<StudentCourse> StudentCourse { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI_ManyToMany_003
{
    public class StudentCourse
    {
        public int StudentId { get; set; }
        public Student Students { get; set; }

        public int CourseId { get; set; }
        public Course Courses { get; set; }
    }
}

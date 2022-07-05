using System;
using System.Collections.Generic;

namespace DemoSchoolConnection.Models
{
    public partial class Student
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}

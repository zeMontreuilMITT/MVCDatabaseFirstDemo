using System;
using System.Collections.Generic;

namespace DemoSchoolConnection.Models
{
    public partial class Course
    {
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int? InstructorId { get; set; }

        public virtual Instructor? Instructor { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}

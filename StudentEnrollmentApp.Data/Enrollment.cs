namespace StudentEnrollmentApp.Data
{
    public class Enrollment : BaseEntity
    {
        public int CourseId { get; set; }
        public int StudnetId { get; set; }

        public virtual Course CourseCourse { get; set; }
        public virtual Student Student { get; set; }
    }
}
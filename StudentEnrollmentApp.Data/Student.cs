namespace StudentEnrollmentApp.Data
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateofBirth { get; set; }
        public string IdNumber { get; set; }
        public string Picture { get; set; }
    }
}
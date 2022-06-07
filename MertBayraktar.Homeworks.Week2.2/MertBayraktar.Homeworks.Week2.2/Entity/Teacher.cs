namespace MertBayraktar.Homeworks.Week2._2.Entity
{
    public class Teacher : BaseEntity
    {
        public string LastName { get; set; }

        public string Email { get; set; }

        public decimal Salary { get; set; }

        public string PhoneNumber { get; set; }


        //Navigation Property
        public int LessonId { get; set; }

        public Lesson Lesson { get; set; }


    }
}

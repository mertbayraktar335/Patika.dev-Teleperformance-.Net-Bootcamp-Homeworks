namespace MertBayraktar.Homeworks.Week2._2.Entity
{
    public class Class : BaseEntity
    {
        //Navigation Property
        public ICollection<Student> Students { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}

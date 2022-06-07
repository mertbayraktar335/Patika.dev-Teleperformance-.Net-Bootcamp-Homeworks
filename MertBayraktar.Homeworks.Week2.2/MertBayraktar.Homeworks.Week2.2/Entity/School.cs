namespace MertBayraktar.Homeworks.Week2._2.Entity
{
    public class School : BaseEntity
    {

        public string Email { get; set; }

        public string Adress { get; set; }

        //Navigation Property
        public ICollection<Student> Students { get; set; }


    }
}

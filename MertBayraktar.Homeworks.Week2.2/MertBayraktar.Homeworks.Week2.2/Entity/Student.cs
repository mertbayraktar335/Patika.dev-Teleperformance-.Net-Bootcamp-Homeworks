namespace MertBayraktar.Homeworks.Week2._2.Entity
{
    public class Student : BaseEntity
    {
        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }


        //Navigation Property
        public int SchoolId { get; set; }

        public School School { get; set; }

        public int ClassId { get; set; }

        public Class Class { get; set; }




    }
}

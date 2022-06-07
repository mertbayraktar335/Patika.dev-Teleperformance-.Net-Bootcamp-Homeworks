namespace MertBayraktar.Homeworks.Week2._2.Entity
{
    
        public class Lesson : BaseEntity
        {

            //Navigation Property
            public ICollection<Teacher> Teachers { get; set; }
            public ICollection<Class> Classes { get; set; }

        }
    
}

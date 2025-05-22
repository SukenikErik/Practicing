

namespace GymApp
{
    public enum Gender { Female, Male };
    public class Person
    {
        public string Name { get; set; }    
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public bool Employee { get; set; }
        public int Times { get; set; }
        public bool IsInside { get; set; }
    }
}

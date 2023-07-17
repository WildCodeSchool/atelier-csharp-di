namespace atelier_injection_dependance.Models
{
    public class Student
    {
        public String Name { get; set; }
        public Student(string name)
        {
            Name = name;
        }
    }
}

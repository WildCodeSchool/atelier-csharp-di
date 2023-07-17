using atelier_injection_dependance.Models;
using Microsoft.AspNetCore.Mvc;

namespace atelier_injection_dependance.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        [HttpGet("/students")]
        public List<Student> GetStudents()
        {
            return FindAll();
        }

        private List<Student> FindAll()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Bernard"));
            students.Add(new Student("Hoagie"));
            students.Add(new Student("Laverne"));
            return students;
        }
    }
}

using API_UI_CORS_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_UI_CORS_Application.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public List<Student> GenerateStudent()
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 100; i++)
            {
                Student student = new Student
                {
                    Id = FakeData.NumberData.GetNumber(i),
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Address = FakeData.PlaceData.GetAddress(),
                };
                students.Add(student);
            }
            return students;

        }

    }
}


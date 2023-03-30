using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scholar.Web.Interfaces;

namespace Scholar.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        [HttpGet(Name = "get-student")]

        public string GetStudentById(int id)
        {
            studentService.GetStudentById(id);
            return "Works " + id.ToString();
        }
    }
}

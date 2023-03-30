using Scholar.Web.Interfaces;
using Scholar.Web.Models;

namespace Scholar.Web.Services
{
    public class StudentService : IStudentService
    {
        public Student GetStudentById(int id)
        {
            return new Student();
        }
    }
}

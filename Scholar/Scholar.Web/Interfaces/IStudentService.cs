using Scholar.Web.Models;

namespace Scholar.Web.Interfaces
{
    public interface IStudentService
    {
        Student GetStudentById(int id);
    }
}

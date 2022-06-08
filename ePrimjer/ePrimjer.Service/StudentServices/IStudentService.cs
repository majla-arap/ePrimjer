using ePrimjer.Infrastracture;

namespace ePrimjer.Service.StudentServices
{
    public interface IStudentService
    {
        StudentDto GetStudentByName(string name);
    }
}
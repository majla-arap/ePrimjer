using ePrimjer.Core;

namespace ePrimjer.Infrastracture
{
    public interface IStudentRepository 
    {
        StudentDto GetByIndex(string name);
    }
}

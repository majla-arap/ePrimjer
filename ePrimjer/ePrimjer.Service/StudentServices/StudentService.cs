using ePrimjer.Core;
using ePrimjer.Infrastracture;
using ePrimjer.Infrastracture.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePrimjer.Service.StudentServices
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public StudentDto GetStudentByName(string name)
        {
            return _studentRepository.GetByIndex(name);
        }
    }
}

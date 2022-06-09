using ePrimjer.Core;
using ePrimjer.Infrastracture;
using ePrimjer.Infrastracture.BaseRepository;
using ePrimjer.Infrastracture.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePrimjer.Service.StudentServices
{
    public class StudentService : IStudentService
    {
        UnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        public StudentDto GetStudentByName(string name)
        {
            return _unitOfWork._StudentRepository.GetByIndex(name);
        }
    }
}

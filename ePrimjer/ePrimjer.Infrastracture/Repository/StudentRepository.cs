using ePrimjer.Core;
using ePrimjer.Infrastracture.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ePrimjer.Infrastracture
{
    public class StudentRepository : BaseRepository<Student, int>, IStudentRepository
    {

        public StudentRepository(DatabaseContext dbc) : base(dbc)
        {
        }

        public StudentDto GetByIndex(string name)
        {
           var obj= _dbset.Where(x=>x.indexNumber==name).FirstOrDefault();
            var st = new StudentDto
            {
                indexNumber = obj.indexNumber,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                BirthDate = obj.BirthDate,
                Gender = obj.Gender
            };
            return st;
           
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePrimjer.Infrastracture.UnitOfWork
{

    public class UnitOfWork : IUnitOfWork 
    {
        protected DatabaseContext _db;
       public IStudentRepository _StudentRepository  { get; }

        

        public UnitOfWork(DatabaseContext db,IStudentRepository studentRepository)
        {
            _db = db;
            _StudentRepository = studentRepository;
        }

        public void BeginTransaction()
        {
            _db.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
           _db.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
           _db.Database.RollbackTransaction();
        }
    }
}

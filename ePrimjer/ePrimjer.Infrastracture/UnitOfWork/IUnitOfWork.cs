namespace ePrimjer.Infrastracture.UnitOfWork
{
    public interface IUnitOfWork
    {

        public void BeginTransaction();
        public void CommitTransaction();
        public void RollbackTransaction();
        public IStudentRepository _StudentRepository { get;  }
    }
}
namespace ePrimjer.Core
{
    public interface IStudent
    {
        public string indexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

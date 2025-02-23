namespace MyHr.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Pesel { get; set; } = default!;
        public DateTime? DateOfBirth { get; set; }
        public DateTime? StartWorkDate { get; set; }
        public DateTime? EndWorkDate { get; set; }
        public Address Address { get; set; } = default!;
    }
}

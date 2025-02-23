namespace MyHr.Domain.Entities
{
    public class Address
    {
        public string? Country { get; set; }
        public string City { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string HouseNumber { get; set; } = default!;
        public string? ApartmentNumber { get; set; }
        public string PostalCode { get; set; } = default!;
        public string? PhoneNumber { get; set; }
    }
}

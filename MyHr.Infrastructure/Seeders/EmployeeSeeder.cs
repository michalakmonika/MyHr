using MyHr.Domain.Entities;
using MyHr.Infrastructure.Persistence;

namespace MyHr.Infrastructure.Seeders
{
    public class EmployeeSeeder
    {
        private readonly MyHrDbContext _dbContext;

        public EmployeeSeeder(MyHrDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Employees.Any())
                {
                    var employees = new List<Employee>()
                    {
                        new Employee()
                        {
                            FirstName = "Anna",
                            LastName = "Kowalska",
                            Pesel = "94010203120",
                            DateOfBirth = new DateTime(1994, 1, 2),
                            StartWorkDate = new DateTime(2025, 1, 10),
                            Address = new()
                            {
                                Country = "Polska",
                                City = "Poznań",
                                Street = "Warszawska",
                                HouseNumber = "100",
                                ApartmentNumber = "20",
                                PostalCode = "60-200",
                                PhoneNumber = "+48900800700",
                            }
                        },
                        new Employee()
                        {
                            FirstName = "Tomasz",
                            LastName = "Nowak",
                            Pesel = "81102838591",
                            DateOfBirth = new DateTime(1981, 10, 28),
                            StartWorkDate = new DateTime(2023, 8, 15),
                            EndWorkDate = new DateTime(2024, 12, 31),
                            Address = new()
                            {
                                Country = "Polska",
                                City = "Wrocław",
                                Street = "Główna",
                                HouseNumber = "55C",
                                PostalCode = "50-320",
                                PhoneNumber = "+48555000444",
                            }
                        }
                    };

                    foreach (Employee emp in employees)
                    {
                        _dbContext.Employees.Add(emp);
                    }
                    
                    _dbContext.SaveChanges();
                }
            }
        }
    }
}

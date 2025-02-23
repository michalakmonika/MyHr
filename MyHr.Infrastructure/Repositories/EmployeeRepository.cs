using Microsoft.EntityFrameworkCore;
using MyHr.Domain.Entities;
using MyHr.Domain.Interfaces;
using MyHr.Infrastructure.Persistence;

namespace MyHr.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MyHrDbContext _dbContext;

        public EmployeeRepository(MyHrDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Employee employee)
        {
            _dbContext.Add(employee);
            _dbContext.SaveChangesAsync();
        }

        public Employee? GetByPesel(string pesel)
        {
            return _dbContext.Employees.FirstOrDefault(e => e.Pesel == pesel);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _dbContext.Employees.ToList();
        }

    }
}

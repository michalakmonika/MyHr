using MyHr.Domain.Entities;

namespace MyHr.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        void Create(Employee employee);
        Employee? GetByPesel(string pesel);
        IEnumerable<Employee> GetAll();
    }
}

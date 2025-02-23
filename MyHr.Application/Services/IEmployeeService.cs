using MyHr.Application.Dtos;
using MyHr.Domain.Entities;

namespace MyHr.Application.Services
{
    public interface IEmployeeService
    {
        void Create(EmployeeDto employeeDto);
        IEnumerable<EmployeeDto> GetAll();
    }
}

using AutoMapper;
using MyHr.Application.Dtos;
using MyHr.Domain.Entities;
using MyHr.Domain.Interfaces;

namespace MyHr.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public void Create(EmployeeDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);

            _employeeRepository.Create(employee);
        }

        public IEnumerable<EmployeeDto> GetAll()
        {
            var employees = _employeeRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return dtos;
        }
    }
}

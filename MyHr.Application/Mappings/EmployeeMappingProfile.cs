using AutoMapper;
using MyHr.Application.Dtos;
using MyHr.Domain.Entities;

namespace MyHr.Application.Mappings
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<EmployeeDto, Employee>()
                .ForMember(e => e.Address, opt => opt.MapFrom(src => new Address()
                {
                    Country = src.Country,
                    City = src.City,
                    Street = src.Street,
                    HouseNumber = src.HouseNumber,
                    ApartmentNumber = src.ApartmentNumber,
                    PostalCode = src.PostalCode,
                    PhoneNumber = src.PhoneNumber
                }));

            CreateMap<Employee, EmployeeDto>()
                .ForMember(dto => dto.Country, opt => opt.MapFrom(src => src.Address.Country))
                .ForMember(dto => dto.City, opt => opt.MapFrom(src => src.Address.City))
                .ForMember(dto => dto.Street, opt => opt.MapFrom(src => src.Address.Street))
                .ForMember(dto => dto.HouseNumber, opt => opt.MapFrom(src => src.Address.HouseNumber))
                .ForMember(dto => dto.ApartmentNumber, opt => opt.MapFrom(src => src.Address.ApartmentNumber))
                .ForMember(dto => dto.PostalCode, opt => opt.MapFrom(src => src.Address.PostalCode))
                .ForMember(dto => dto.PhoneNumber, opt => opt.MapFrom(src => src.Address.PhoneNumber));
        }
    }
}

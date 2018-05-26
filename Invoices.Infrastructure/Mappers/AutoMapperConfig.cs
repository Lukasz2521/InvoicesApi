using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;
using Invoices.Infrastructure.DTO;
using Invoices.Infrastructure.Commands.Company;
using Invoices.Infrastructure.Commands.User;

namespace Invoices.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg => {
                cfg.CreateMap<CompanyDTO, Company>();
                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<Contractor, ContractorDTO>();
                cfg.CreateMap<CreateCompany, CompanyDTO>();
                cfg.CreateMap<CreateUser, UserDTO>();
                cfg.CreateMap<User, UserDTO>();
            })
            .CreateMapper();
    }
}

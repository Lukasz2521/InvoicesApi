using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Invoices.Core.Domain;
using Invoices.Infrastructure.DTO;

namespace Invoices.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg => {
                cfg.CreateMap<Company, CompanyDTO>();
                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<Contractor, ContractorDTO>();
            })
            .CreateMapper();
    }
}

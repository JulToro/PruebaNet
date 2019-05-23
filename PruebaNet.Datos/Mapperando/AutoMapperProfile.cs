using AutoMapper;
using PruebaNet.Datos.DTO;
using PruebaNet.Negocio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.Adapters.Mapper.Mapeando
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Client, ClientDTO>().ForMember(x => x.identification, opt => opt.MapFrom(src => src.identification))
                                          .ForMember(x => x.name, opt => opt.MapFrom(src => src.name))
                                          .ForMember(x => x.phoneNumber, opt => opt.MapFrom(src => src.phoneNumber))
                                          .ForMember(x => x.addres, opt => opt.MapFrom(src => src.addres))
                                          .ForMember(x => x.city, opt => opt.MapFrom(src => src.city))
                                          .ForMember(x => x.email, opt => opt.MapFrom(src => src.email)
                                         );
            CreateMap<ClientDTO, Client>().ForMember(x => x.identification, opt => opt.MapFrom(src => src.identification))
                              .ForMember(x => x.name, opt => opt.MapFrom(src => src.name))
                              .ForMember(x => x.phoneNumber, opt => opt.MapFrom(src => src.phoneNumber))
                              .ForMember(x => x.addres, opt => opt.MapFrom(src => src.addres))
                              .ForMember(x => x.city, opt => opt.MapFrom(src => src.city))
                              .ForMember(x => x.email, opt => opt.MapFrom(src => src.email)
                             );

            CreateMap<EmployeeDTO, Employee>().ForMember(x => x.identification, opt => opt.MapFrom(src => src.identification))
                              .ForMember(x => x.name, opt => opt.MapFrom(src => src.name)
                             );
            CreateMap<Employee, EmployeeDTO>().ForMember(x => x.identification, opt => opt.MapFrom(src => src.identification))
                                .ForMember(x => x.name, opt => opt.MapFrom(src => src.name)
                                );
            CreateMap<OrderDTO, Order>().ForMember(x => x.clientId, opt => opt.MapFrom(src => src.clientId))
                                        .ForMember(x => x.commentary, opt => opt.MapFrom(src => src.commentary))
                                        .ForMember(x => x.employeeId, opt => opt.MapFrom(src => src.employeeId))
                                        .ForMember(x => x.products, opt => opt.MapFrom(src => src.products)
                                        );
            CreateMap<Order, OrderDTO>().ForMember(x => x.clientId, opt => opt.MapFrom(src => src.clientId))
                            .ForMember(x => x.commentary, opt => opt.MapFrom(src => src.commentary))
                            .ForMember(x => x.employeeId, opt => opt.MapFrom(src => src.employeeId))
                            .ForMember(x => x.products, opt => opt.MapFrom(src => src.products)
                            );
            CreateMap<Product, ProductDTO>().ForMember(x => x.idProduct, opt => opt.MapFrom(src => src.idProduct))
                .ForMember(x => x.nameProduct, opt => opt.MapFrom(src => src.nameProduct))
                .ForMember(x => x.PLU, opt => opt.MapFrom(src => src.PLU))
                .ForMember(x => x.commentary, opt => opt.MapFrom(src => src.commentary))
                .ForMember(x => x.tax, opt => opt.MapFrom(src => src.tax))
                .ForMember(x => x.value, opt => opt.MapFrom(src => src.value)
                );
            CreateMap<ProductDTO, Product>().ForMember(x => x.idProduct, opt => opt.MapFrom(src => src.idProduct))
                                            .ForMember(x => x.nameProduct, opt => opt.MapFrom(src => src.nameProduct))
                                            .ForMember(x => x.PLU, opt => opt.MapFrom(src => src.PLU))
                                            .ForMember(x => x.commentary, opt => opt.MapFrom(src => src.commentary))
                                            .ForMember(x => x.tax, opt => opt.MapFrom(src => src.tax))
                                            .ForMember(x => x.value, opt => opt.MapFrom(src => src.value)
    );
        }
    }
}

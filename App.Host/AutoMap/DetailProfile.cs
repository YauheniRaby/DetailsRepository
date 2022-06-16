using AppData.Model;
using AppServices.DTOs;
using AutoMapper;
using System;

namespace AppHost.AutoMap
{
    public class DetailProfile : Profile
    {
        public DetailProfile()
        {
            CreateMap<CreateDetailDTO, Detail>()
                .ForMember(dest => dest.CreatedDate, conf => conf.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.Employee, opt => opt.Ignore())
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.RemoveDate, opt => opt.Ignore());
            CreateMap<UpdateDetailDTO, Detail>()
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
                .ForMember(dest => dest.Employee, opt => opt.Ignore())
                .ForMember(dest => dest.RemoveDate, opt => opt.Ignore());
            CreateMap<Detail, DetailDTO>();
        }
    }
}
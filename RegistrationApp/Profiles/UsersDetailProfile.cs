using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrationApp.Entities;
using RegistrationApp.Models;
using RegistrationApp.Services;

namespace RegistrationApp.Profiles
{
    public class UsersDetailProfile : Profile
    {
        public UsersDetailProfile()
        {
            CreateMap<UsersDetail, UsersDetailDto>()
                .ForMember(
                    dest => dest.Address,
                    opt => opt.MapFrom(src => $"{src.HouseNumber}, {src.Street}, {src.ZipCode}"));

            CreateMap<UsersDetailsForCreationDto, UsersDetail>();
        }
    }
}

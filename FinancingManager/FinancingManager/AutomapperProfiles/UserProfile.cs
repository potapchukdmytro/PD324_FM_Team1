using AutoMapper;
using FinancingManager.Entities;
using FinancingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancingManager.AutomapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterModel, UserEntity>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FirstName));
        }
    }
}

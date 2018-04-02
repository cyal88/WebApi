using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessEntities;
using DataModel;

namespace BusinessServices
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Products, ProductEntity>();
            CreateMap<Tokens, TokenEntity>();
            CreateMap<User, UserEntity>();
        }

    }
}

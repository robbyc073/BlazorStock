using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorStock.Server.Entities.Models;
using BlazorStock.Server.Entities;
using BlazorStock_DataAccess;

namespace Tangy_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StockUser, StockUserDTO>().ReverseMap();
            CreateMap<StockTransaction, StockTransactionDTO>().ReverseMap();
        }
    }
}

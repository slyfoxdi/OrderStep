using AutoMapper;
using OrderStep.Core.Model;
using OrderStep.Infrastracture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Domain.Configuration.Profiles
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Order, OrderDao>();
        }
    }
}

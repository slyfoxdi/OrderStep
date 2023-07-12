using AutoMapper;
using OrderStep.Application.Command.SaveOrder;
using OrderStep.WebApi.Model;
using CoreApp = OrderStep.Core.Model;

namespace OrderStep.WebApi.Configuration.Profiles
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<CoreApp.BaseResponse<CoreApp.Client>, BaseResponse<Client>>();
            CreateMap<CoreApp.BaseResponse<int>, BaseResponse<int>>();
            CreateMap<CoreApp.BaseResponse<bool>, BaseResponse<bool>>();
            CreateMap<CoreApp.UserAndRight, UserAndRight>();
            CreateMap<CoreApp.Client, Client>();
            CreateMap<Order, CoreApp.Order>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id));
        }
    }
}

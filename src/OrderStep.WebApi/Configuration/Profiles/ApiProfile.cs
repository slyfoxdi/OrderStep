using AutoMapper;
using OrderStep.WebApi.Model;
using CoreApp = OrderStep.Core.Model;

namespace OrderStep.WebApi.Configuration.Profiles
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<CoreApp.BaseResponse<CoreApp.Client>, BaseResponse<Client>>();
            CreateMap<CoreApp.Client, Client>();
        }
    }
}

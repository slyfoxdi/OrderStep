using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MediatR;

namespace OrderStep.WebApi.Controllers
{
    public partial class BaseController : Controller
    {
        protected readonly IMediator _mediator;
        protected readonly IMapper _mapper;
        protected readonly ILogger<BaseController> _logger;

        public BaseController(IMediator mediator, IMapper mapper, ILogger<BaseController> logger)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}

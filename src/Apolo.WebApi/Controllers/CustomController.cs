using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Apolo.WebApi.Controllers
{
    public class CustomController : Controller
    {
        private readonly IMediator _mediator;

        public CustomController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
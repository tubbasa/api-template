using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TubaMiddleWareWebApp.Models;
using TubaMiddleWareWebApp.Service.Sample;

namespace TubaMiddleWareWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IMediator _mediator;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet("GetSample")]
        public async Task<bool> Sample()
        {
            return await _mediator.Send(new GetSampleServiceRequest { Id = 0 });
        }

    }
}
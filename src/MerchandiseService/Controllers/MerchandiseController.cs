using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;
using MediatR;
using MerchandiseService.Infrastructure.Commands;
using MerchandiseService.Models;
using MerchandiseService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MerchandiseService.Controllers
{
    
    [ApiController]
    [Route("v1/api/merchs")]
    public class MerchandiseController : ControllerBase
    {
        private readonly IMerchandiseBusinessService _merchandiseBusinessService;
        private readonly IMediator _mediator;

        public MerchandiseController(IMerchandiseBusinessService merchandiseBusinessService, IMediator mediator)
        {
            _merchandiseBusinessService = merchandiseBusinessService;
            _mediator = mediator;
        }

        [HttpGet("{employeeId:long}")]
        public async Task<IActionResult>GetEmployeeMerchInfoAsync(int employeeId, CancellationToken token)
        {
            var command = new EmployeeMerchPackInfoCommand(employeeId);
            var merchInfo = await _mediator.Send(command);
            return Ok(merchInfo);
        }

        [HttpGet("{employeeId:long}/{merchType:long}")]
        public async Task<IActionResult> GetMerchAsync(long employeeId, long merchType, CancellationToken token)
        {
            var result = await _merchandiseBusinessService.GetMerchAsync(employeeId, merchType, token); 
            return Ok(result);
        }
    }
}
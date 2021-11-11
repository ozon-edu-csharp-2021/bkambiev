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
        private readonly IMediator _mediator;

        public MerchandiseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{employeeId:int}")]
        public async Task<IActionResult>GetEmployeeMerchInfoAsync(int employeeId, CancellationToken token)
        {
            var command = new EmployeeMerchPackInfoCommand(employeeId);
            var merchInfo = await _mediator.Send(command, token);
            return Ok(merchInfo);
        }

        [HttpGet("{employeeId:long}/{merchTypeId:int}")]
        public async Task<IActionResult> GetMerchPackAsync(int employeeId, int merchTypeId, CancellationToken token)
        {
            var command = new GetMerchPackCommand(employeeId, merchTypeId);
            var result = await _mediator.Send(command, token); 
            return Ok(result);
        }
    }
}
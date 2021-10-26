using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CSharpCourse.Core.Lib.Enums;
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

        public MerchandiseController(IMerchandiseBusinessService merchandiseBusinessService)
        {
            _merchandiseBusinessService = merchandiseBusinessService;
        }

        [HttpGet("{employeeId:long}")]
        public async Task<IActionResult>GetEmployeeMerchInfo(long employeeId, CancellationToken token)
        {
            var merchInfo = _merchandiseBusinessService.GetEmployeeMerchInfo(employeeId, token);
            throw new NotImplementedException();
        }

        [HttpGet("{employeeId:long}/{merchType:long}")]
        public async Task<IActionResult> GetMerch(long employeeId, long merchType, CancellationToken token)
        {
            var result = _merchandiseBusinessService.GetMerch(employeeId, merchType, token); 
            throw new NotImplementedException();
        }
    }
}
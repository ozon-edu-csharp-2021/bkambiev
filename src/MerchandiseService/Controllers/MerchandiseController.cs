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
        public async Task<IActionResult>GetEmployeeMerchInfoAsync(long employeeId, CancellationToken token)
        {
            try
            {
                var merchInfo = await _merchandiseBusinessService.GetEmployeeMerchInfoAsync(employeeId, token);
                return Ok(merchInfo);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        [HttpGet("{employeeId:long}/{merchType:long}")]
        public async Task<IActionResult> GetMerchAsync(long employeeId, long merchType, CancellationToken token)
        {
            var result = await _merchandiseBusinessService.GetMerchAsync(employeeId, merchType, token); 
            return Ok(result);
        }
    }
}
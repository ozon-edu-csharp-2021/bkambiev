using System;
using System.Text.Json;
using System.Threading.Tasks;
using Grpc.Core;
using MediatR;
using Merchandise.Grpc;
using MerchandiseService.Domain.AggregationModels.MerchPackRequest;
using MerchandiseService.Infrastructure.Commands;
using MerchandiseService.Models;

namespace MerchandiseService.GrpcServices
{
    public class MerchandiseGrpService : MerchandiseGrpc.MerchandiseGrpcBase
    {
        private readonly IMediator _mediator;

        public MerchandiseGrpService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override async Task<GetEmployeeMerchInfoResponse> GetEmployeeMerchInfo(GetEmployeeMerchInfoRequest request, ServerCallContext context)
        {
            var command = new EmployeeMerchPackInfoCommand(request.EmployeeId);
            var merchInfo = await _mediator.Send(command, context.CancellationToken);
            return new GetEmployeeMerchInfoResponse
            {
                
            };
        }

        public override async Task<GetMerchResponse> GetMerchPack(GetMerchRequest request, ServerCallContext context)
        {
            GetMerchRequestHttp getMerchRequestHttp = JsonSerializer.Deserialize<GetMerchRequestHttp>(request.Requeststring);
            MerchPackRequest merchPackRequest = new MerchPackRequest(
                getMerchRequestHttp.Employee,
                getMerchRequestHttp.Email,
                getMerchRequestHttp.MerchType,
                DateTimeOffset.Now,
                null
                );
            var command = new GetMerchPackCommand(merchPackRequest);
            int resultGetMerch = await _mediator.Send(command, context.CancellationToken);
            return new GetMerchResponse
            {
                Result = resultGetMerch
            };
        }
    }
}
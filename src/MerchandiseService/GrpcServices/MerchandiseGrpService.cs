using System.Threading.Tasks;
using Grpc.Core;
using MediatR;
using Merchandise.Grpc;
using MerchandiseService.Infrastructure.Commands;
using MerchandiseService.Services.Interfaces;

namespace MerchandiseService.GrpcServices
{
    public class MerchandiseGrpService : MerchandiseGrpc.MerchandiseGrpcBase
    {
        private readonly IMerchandiseBusinessService _merchandiseBusinessService;
        private readonly IMediator _mediator;

        public MerchandiseGrpService(IMerchandiseBusinessService merchandiseBusinessService, IMediator mediator)
        {
            _merchandiseBusinessService = merchandiseBusinessService;
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

        public override async Task<GetMerchResponse> GetMerch(GetMerchRequest request, ServerCallContext context)
        {
            //var resultGetMerch = await _merchandiseBusinessService.GetMerchAsync(request.EmployeeId, request.MerchType, context.CancellationToken);
            var command = new GetMerchPackCommand(request.EmployeeId, request.MerchType);
            int resultGetMerch = await _mediator.Send(command, context.CancellationToken);
            return new GetMerchResponse
            {
                Result = resultGetMerch != 0
            };
        }
    }
}
using System.Threading.Tasks;
using Grpc.Core;
using Merchandise.Grpc;
using MerchandiseService.Services.Interfaces;

namespace MerchandiseService.GrpcServices
{
    public class MerchandiseGrpService : MerchandiseGrpc.MerchandiseGrpcBase
    {
        private readonly IMerchandiseBusinessService _merchandiseBusinessService;

        public MerchandiseGrpService(IMerchandiseBusinessService merchandiseBusinessService)
        {
            _merchandiseBusinessService = merchandiseBusinessService;
        }

        public override async Task<GetEmployeeMerchInfoResponse> GetEmployeeMerchInfo(GetEmployeeMerchInfoRequest request, ServerCallContext context)
        {
            var merchInfo =
                _merchandiseBusinessService.GetEmployeeMerchInfo(request.EmployeeId, context.CancellationToken);
            return new GetEmployeeMerchInfoResponse
            {
                
            };
        }

        public override async Task<GetMerchResponse> GetMerch(GetMerchRequest request, ServerCallContext context)
        {
            var resultGetMerch =
                _merchandiseBusinessService.GetMerch(request.EmployeeId, request.MerchType, context.CancellationToken);
            return new GetMerchResponse
            {
                Result = resultGetMerch.Result
            };
        }
    }
}
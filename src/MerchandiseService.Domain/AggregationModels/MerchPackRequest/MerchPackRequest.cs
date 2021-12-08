using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseService.Domain.AggregationModels.MerchPackRequest
{
    public class MerchPackRequest : Entity
    {
        public MerchPackRequestStatus Status { get; private set; }

        public Employee Employee { get; }

        public MerchType MerchPackType { get; }

        public DateTimeOffset CreatedDate { get; }

        public DateTimeOffset? CLosedDate { get; private set; }

        


        public MerchPackRequest(
            Employee employee,
            MerchType merchPackType,
            DateTimeOffset createdDate,
            DateTimeOffset? cLosedDate,
            MerchPackRequestStatus status)
        {
            Status = status;
            Employee = employee;
            MerchPackType = merchPackType;
            CreatedDate = createdDate;
            CLosedDate = cLosedDate;
        }

        public void SetClosedDate()
        {
            CLosedDate = DateTimeOffset.Now;
        }

        public void Processing()
        {
            Status = MerchPackRequestStatus.Processing;
        }

        public void Done()
        {
            Status = MerchPackRequestStatus.Done;
            SetClosedDate();
        }

        public void Decline()
        {
            Status = MerchPackRequestStatus.Decline;
            SetClosedDate();
        }
    }
}

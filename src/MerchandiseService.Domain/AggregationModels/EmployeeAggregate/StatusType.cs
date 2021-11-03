using CSharpCourse.Core.Lib.Enums;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.EmployeeAggregate
{
    public class StatusType : Enumeration
    {
        public static StatusType Welcome = new(1, nameof(Welcome));
        public static StatusType ProbationPeriodEnding = new(2, nameof(ProbationPeriodEnding));
        public static StatusType Veteran = new(3, nameof(Veteran));
        public static StatusType ConferenceListener = new(4, nameof(ConferenceListener));
        public static StatusType ConferenceSpeaker = new(5, nameof(ConferenceSpeaker));

        public StatusType(int id, string name) : base(id, name)
        {
            
        }
    }
}
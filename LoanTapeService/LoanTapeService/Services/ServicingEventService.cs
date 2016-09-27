using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoanTapeService.Models;

namespace LoanTapeService.Services
{
    public class ServicingEventService : IServicingEventService
    {
        private List<ServicingEvent> ServicingEvents { get; set; }


        public ServicingEventService()
        {
            ServicingEvents = new List<ServicingEvent>
            {
                new OriginationEvent
                {
                    Id =1,
                    LoanId = 1,
                    Amount = 5000,
                    APR = 2.5,
                    MonthlyPayment = 500
                }
            };
        }

        public IEnumerable<ServicingEvent> GetAll(int loanId, EventType? eventType)
        {
            var query = from se in ServicingEvents
                        where se.LoanId == loanId && (!eventType.HasValue || eventType.Value==se.EventType)
                        orderby se.CreatedDt descending
                        select se;

            return query.ToList();
        }

        public Result<ServicingEvent> Create(ServicingEvent servicingEvent)
        {
            var result = new Result<ServicingEvent>();
            ServicingEvents.Add(servicingEvent);
            result.Data = servicingEvent;
            return result;
        }
    }
}
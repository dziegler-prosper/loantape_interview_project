using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using LoanTapeService.Models;

namespace LoanTapeService.Services
{
    public interface IServicingEventService
    {
        IEnumerable<ServicingEvent> GetAll(int loanId, EventType? eventType);

        Result<ServicingEvent> Create(ServicingEvent servicingEvent);
    }

}


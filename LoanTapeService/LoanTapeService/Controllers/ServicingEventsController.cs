using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using LoanTapeService.Models;
using LoanTapeService.Services;

namespace LoanTapeService.Controllers
{
    [RoutePrefix("api/loans")]
    public class ServicingEventsController : ApiController
    {
        private readonly INotificationService _notificationService;

        private  IServicingEventService ServicingEventService { get; set; }

        public ServicingEventsController() : this(new ServicingEventService(), new NotificationService())
        {
        }


        public ServicingEventsController(IServicingEventService servicingEventService, INotificationService notificationService)
        {
            _notificationService = notificationService;
            ServicingEventService = servicingEventService;
        }

        [AcceptVerbs("GET")]
        [Route("{loanId}/events")]
        public IHttpActionResult Get(int loanId,[FromUri] EventType? eventType = null)
        {
            if (loanId == 0) return BadRequest("Loan Id is not valid");
            var servicingEvents = ServicingEventService.GetAll(loanId, eventType);
            return Ok((servicingEvents));
        }

        [AcceptVerbs("PUT")]
        [Route("{loanId}/events")]
        public IHttpActionResult Put(int loanId, [FromBody]ServicingEvent servicingEvent)
        {
            if (loanId == 0) return BadRequest("Loan Id is not valid");


            var result = ServicingEventService.Create(servicingEvent);
            if (result.IsSuccess)
            {
                _notificationService.Send(result.Data);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}

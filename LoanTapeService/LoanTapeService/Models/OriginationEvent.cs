using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanTapeService.Models
{
    public class OriginationEvent: ServicingEvent
    {

        public OriginationEvent()
        {
            EventType = EventType.Origination;
            
        }
       
        public double Amount { get; set; }

        public double APR { get; set; }

        public double MonthlyPayment { get; set; }
    }
}
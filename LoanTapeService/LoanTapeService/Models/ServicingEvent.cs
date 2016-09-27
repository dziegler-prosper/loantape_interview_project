using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanTapeService.Models
{
    public class ServicingEvent
    {

        public int Id { get; set; }

        public int LoanId { get; set; }

        [Required]
        public EventType EventType { get; set; }

        [Required]
        public DateTime CreatedDt { get; set; }

        [Required]
        public int CreatedBy { get; set; }

    }

    public enum EventType
    {
        Disbursement,
        Origination,
        PaymentSubmitted
    }
}
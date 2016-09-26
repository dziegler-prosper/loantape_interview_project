using System;

namespace LoanTapeService.Models
{
    public class LoanTapeModel 
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }

        public EventModel eventType { get; set; }

        public AuditorModel auditorType { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanTapeService.Models
{
    public class Action
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public int CustomerId { get; set; }
        public int ActorId { get; set; }
        public int ActionType { get; set; }
        public string Data { get; set; }
    }
}
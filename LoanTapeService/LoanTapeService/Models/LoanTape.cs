using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanTapeService.Models
{
    public class LoanTape
    {
        public Customer Customer { get; set; }
        public Loan Loan { get; set; }
        public IEnumerable<Action> Actions { get; set; }
    }
}
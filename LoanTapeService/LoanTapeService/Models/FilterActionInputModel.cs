using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanTapeService.Models
{
    public class FilterActionInputModel
    {
        public int ActionTypeId { get; set; }
        public int CustomerId { get; set; }
        public int ActionId { get; set; }
        public int LoanId { get; set; }
    }
}
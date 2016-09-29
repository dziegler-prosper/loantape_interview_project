using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanTapeService.LoanActions
{
    public class PaymentAction : LoanAction
    {

        private int _Id = 5;

        public int Id
        {
            get { return _Id; }
        }

        public DateTime PaymentDate { get; set; }
        public int Amount { get; set; }
        public int CustomerId { get; set; }
    }
}
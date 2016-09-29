using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanTapeService.LoanActions
{
    public class OriginationAction : LoanAction
    {
        private int _Id = 2;

        public int Id
        {
            get {  return _Id; }
        }
        public int OriginationDate { get; set; }
        public int Amount { get; set; }
        public int APR { get; set; }
        public int Term { get; set; }
        public string PaymentSchedule { get; set; }
    }
}
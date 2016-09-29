using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanTapeService.LoanActions
{
    public class SignLoanAction : LoanAction
    {
        private int _Id = 1;

        public int Id
        {
            get { return _Id; }
        }
        public string SignedThrough { get; set; }
        public DateTime SignedOn { get; set; }
    }
}
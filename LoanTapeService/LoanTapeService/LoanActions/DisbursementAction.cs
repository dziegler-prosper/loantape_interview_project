using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanTapeService.LoanActions
{
    public class DisbursementAction : LoanAction
    {
        private int _Id = 3;

        public int Id
        {
            get { return _Id; }
        }
    }
}
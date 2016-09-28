using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoanTapeService.Models;
using Action = LoanTapeService.Models.Action;

namespace LoanTapeService.Services
{
    public class DatabaseContext
    {
        public Loan Loan;
       
        public DatabaseContext()
        {
            Loan loan = new Loan()
            {
                Id = 1,
                Amount = 10000,
                Apr = 1.5,
                BorrowerId = 1,
                Events = new List<Action>(),
                LoanType = LoanType.Active,
                OriginalDate = DateTime.Now
            };
            loan.Events.Add(new LoanPayment()
            {
                Id = 1,
                Amount = 100,
                ActionType = ActionType.Payment,
                CreationDate = DateTime.Now
            });
            Loan = loan;
        }

        internal Loan GetLoan(int id)
        {
            //query on list of loans with id
            return Loan;
        }

        internal List<Models.Action> GetActions(int id, string type, string sort)
        {
            //query off actions
            //Loan.Events.Find()
            //sort events
            return null;
        }

        internal void AddAction(Models.Action loanAction)
        {
            Loan.Events.Add(loanAction);
        }
    }
}
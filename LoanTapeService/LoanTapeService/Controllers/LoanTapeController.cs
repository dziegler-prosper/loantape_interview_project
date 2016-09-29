using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LoanTapeService.Models;
using LoanTapeService.LoanActions;
using Action = LoanTapeService.Models.Action;

namespace LoanTapeService.Controllers
{
    [RoutePrefix("api/LoanTape")]
    public class LoanTapeController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: api/Loans/5
        [ResponseType(typeof(LoanTape))]
        public IHttpActionResult GetSnapshot(int loanId)
        {
            Loan loan = db.Loans.Find(loanId);
            Customer customer = db.Customers.Find(loan.CustomerId);
            var actions = db.Actions.Find();
            //var loanActions = from action in actions
            //    where action.CustomerId = customer.Id
            //    select action;
            LoanTape result = new LoanTape();
            result.Loan = loan;
            result.Customer = customer;
            result.Actions = new List<Action>();
            return Ok(loan);
        }

        public IHttpActionResult GetActions(FilterActionInputModel input)
        {
            var actions = db.Actions.Find(input.ActionId);

            return Ok();
        }

        public IHttpActionResult GetActionData(FilterActionInputModel input)
        {
            var actions = db.Actions.Find(input.ActionId);

            return Ok();
        }
    }
}

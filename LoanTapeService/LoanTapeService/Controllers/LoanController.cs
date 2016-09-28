using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LoanTapeService.Models;
using LoanTapeService.Services;

namespace LoanTapeService.Controllers
{
    public class LoanController : ApiController
    {
        private DatabaseContext DBContext;

        public LoanController()
        {
            DBContext = new DatabaseContext();
        }

        // GET api/loan
        [HttpGet]
        public IEnumerable<Loan> Get()
        {
            //return all loans
            return null;
        }

        // GET api/loan/1
        [HttpGet]
        public Loan Get(int id)
        {
            Loan loan = DBContext.GetLoan(id);
            return loan;
        }

        // GET api/loan/1?type=payment
        [HttpGet]
        public IEnumerable<Models.Action> GetActions(int id, string type)
        {
            List<Models.Action> loan = DBContext.GetActions(id, type, "a");
            return loan;
        }

        // GET api/loan/1?type=payment
        [HttpGet]
        public IEnumerable<Models.Action> GetActions(int id, string type, string sort)
        {
            List<Models.Action> actions = DBContext.GetActions(id, type, sort);
            return actions;
        }

        // POST api/loan/1
        [HttpPost]
        public IHttpActionResult Post(int id, [FromBody]Models.Action loanAction)
        {
            DBContext.AddAction(loanAction);
            return Ok("Added Action");
        }

        // POST api/loan
        public void Put(int id, [FromBody]Models.Action loanAction)
        {
            //update to loan action?
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LoanTapeService.Models;

namespace LoanTapeService.Controllers
{
    public class LoanTapeController : ApiController
    {

      private LoanTapeModel[] loans = new LoanTapeModel[]
       {
            new LoanTapeModel {   id = 1,
                date = DateTime.Now,
                description = "sign documents",
                eventType = new EventModel() {id = 1, name = "sign documents", description = "sign documents"},
                auditorType = new AuditorModel() {id = 1, name = "manual", description = "process manual"}
            },
            new LoanTapeModel {   id = 2,
                date = DateTime.Now,
                description = "loan originated",
                eventType = new EventModel() {id = 2, name = "loan originated", description = "loan originated"},
                auditorType = new AuditorModel() {id = 2, name = "automatic", description = "automatic manual"}},
          
       };

        public IEnumerable<LoanTapeModel> GetAllLoans()
        {
            return loans;
        }
      

        public IHttpActionResult GetLoan(int id)
        {
            var loan = loans.FirstOrDefault((p) => p.id == id);
            if (loan == null)
            {
                return NotFound();
            }
            return Ok(loan);
        }
    }
}
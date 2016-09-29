using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LoanTapeService.Models;

namespace LoanTapeService.Controllers
{
    public class ActionsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Actions
        public IQueryable<LoanTapeService.Models.Action> GetActions()
        {
            return db.Actions;
        }

        // GET: api/Actions/5
        [ResponseType(typeof(LoanTapeService.Models.Action))]
        public IHttpActionResult GetAction(int id)
        {
            LoanTapeService.Models.Action action = db.Actions.Find(id);
            if (action == null)
            {
                return NotFound();
            }

            return Ok(action);
        }

        // PUT: api/Actions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAction(int id, LoanTapeService.Models.Action action)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != action.Id)
            {
                return BadRequest();
            }

            db.Entry(action).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Actions
        [ResponseType(typeof(LoanTapeService.Models.Action))]
        public IHttpActionResult PostAction(LoanTapeService.Models.Action action)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Actions.Add(action);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = action.Id }, action);
        }

        // DELETE: api/Actions/5
        [ResponseType(typeof(LoanTapeService.Models.Action))]
        public IHttpActionResult DeleteAction(int id)
        {
            LoanTapeService.Models.Action action = db.Actions.Find(id);
            if (action == null)
            {
                return NotFound();
            }

            db.Actions.Remove(action);
            db.SaveChanges();

            return Ok(action);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ActionExists(int id)
        {
            return db.Actions.Count(e => e.Id == id) > 0;
        }
    }
}
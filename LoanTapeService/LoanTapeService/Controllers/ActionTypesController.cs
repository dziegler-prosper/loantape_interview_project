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
    public class ActionTypesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ActionTypes
        public IQueryable<ActionType> GetActionTypes()
        {
            return db.ActionTypes;
        }

        // GET: api/ActionTypes/5
        [ResponseType(typeof(ActionType))]
        public IHttpActionResult GetActionType(int id)
        {
            ActionType actionType = db.ActionTypes.Find(id);
            if (actionType == null)
            {
                return NotFound();
            }

            return Ok(actionType);
        }

        // PUT: api/ActionTypes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutActionType(int id, ActionType actionType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != actionType.Id)
            {
                return BadRequest();
            }

            db.Entry(actionType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActionTypeExists(id))
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

        // POST: api/ActionTypes
        [ResponseType(typeof(ActionType))]
        public IHttpActionResult PostActionType(ActionType actionType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ActionTypes.Add(actionType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = actionType.Id }, actionType);
        }

        // DELETE: api/ActionTypes/5
        [ResponseType(typeof(ActionType))]
        public IHttpActionResult DeleteActionType(int id)
        {
            ActionType actionType = db.ActionTypes.Find(id);
            if (actionType == null)
            {
                return NotFound();
            }

            db.ActionTypes.Remove(actionType);
            db.SaveChanges();

            return Ok(actionType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ActionTypeExists(int id)
        {
            return db.ActionTypes.Count(e => e.Id == id) > 0;
        }
    }
}
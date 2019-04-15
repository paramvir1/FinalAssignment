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
using _200382884F.Models;

namespace _200382884F.Controllers
{
    public class ChatMessages1Controller : ApiController
    {
        private _200382884FContext db = new _200382884FContext();

        // GET: api/ChatMessages1
        public IQueryable<ChatMessage> GetChatMessages()
        {
            return db.ChatMessages;
        }

        // GET: api/ChatMessages1/5
        [ResponseType(typeof(ChatMessage))]
        public IHttpActionResult GetChatMessage(int id)
        {
            ChatMessage chatMessage = db.ChatMessages.Find(id);
            if (chatMessage == null)
            {
                return NotFound();
            }

            return Ok(chatMessage);
        }

        // PUT: api/ChatMessages1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChatMessage(int id, ChatMessage chatMessage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != chatMessage.ChatMessageId)
            {
                return BadRequest();
            }

            db.Entry(chatMessage).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChatMessageExists(id))
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

        // POST: api/ChatMessages1
        [ResponseType(typeof(ChatMessage))]
        public IHttpActionResult PostChatMessage(ChatMessage chatMessage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ChatMessages.Add(chatMessage);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = chatMessage.ChatMessageId }, chatMessage);
        }

        // DELETE: api/ChatMessages1/5
        [ResponseType(typeof(ChatMessage))]
        public IHttpActionResult DeleteChatMessage(int id)
        {
            ChatMessage chatMessage = db.ChatMessages.Find(id);
            if (chatMessage == null)
            {
                return NotFound();
            }

            db.ChatMessages.Remove(chatMessage);
            db.SaveChanges();

            return Ok(chatMessage);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChatMessageExists(int id)
        {
            return db.ChatMessages.Count(e => e.ChatMessageId == id) > 0;
        }
    }
}
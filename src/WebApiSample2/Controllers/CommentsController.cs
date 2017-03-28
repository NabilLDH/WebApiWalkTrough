using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Ajax.Utilities;
using WebApiSample2.Models;
namespace WebApiSample2.Controllers
{
    public class CommentsController : ApiController
    {
        ICommentRepository repository;

        public CommentsController()
        {
            
        }
        public CommentsController(ICommentRepository repository)
        {
            this.repository = repository;
        }
        // GET api/comments
        public IEnumerable<Comment> GetComments()
        {
            return repository.Get();
        }

        // GET api/comments/5
        public Comment GetComment(int id)
        {
            Comment comment;
            if (!repository.Exists(id, out comment))
                throw new HttpResponseException(HttpStatusCode.NotFound) ;
            return comment;
        }

        // POST api/comments
        public HttpResponseMessage PostComment(Comment comment)
        {
            comment = repository.Add(comment);
            var response = Request.CreateResponse<Comment>(HttpStatusCode.Created,comment);
            response.Headers.Location = new Uri(Request.RequestUri, "/api/comments/" + comment.Id);
            return response;
        }

        // DELETE api/comments/5
        public Comment DeleteComment(int id)
        {
            Comment comment;
            if (!repository.Exists(id, out comment))
                throw new HttpResponseException(HttpStatusCode.NotFound);
            repository.Delete(id);
            return comment;
        }

        // PUT api/comments/5
        public void Put(int id, [FromBody]Comment value)
        {
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSample2.Models
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> Get();
        bool Exists(int id, out Comment comment);
        Comment Add(Comment comment);
        bool Delete(int comment);
        bool Update(Comment comment);


    }
}
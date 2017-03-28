using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace WebApiSample2.Models
{
    public class CommentRepository : ICommentRepository 
    {
        int nextId = 0;
        Dictionary<int,Comment> comments = new Dictionary<int, Comment>(); 
        public IEnumerable<Comment> Get()
        {
            return comments.Values.OrderBy(c => c.Id);
        }

        public bool Exists(int id, out Comment comment)
        {
            return comments.TryGetValue(id, out comment);
        }

        public Comment Add(Comment comment)
        {
            comment.Id = nextId ++;
            comments[comment.Id] = comment;
            return comment;
        }

        public bool Delete(int id)
        {
            return comments.Remove(id);
        }

        public bool Update(Comment comment)
        {
            bool update = comments.ContainsKey(comment.Id);
            comments[comment.Id] = comment;
            return update;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Comment.API.Data;

namespace Comment.API.Repositories
{
    public interface ICommentRepository : IRepository<Models.Comment>
    {
        IEnumerable<Models.Comment> GetByPostId(Guid postId);
    }
    public class CommentRepository : Repository<Models.Comment>, ICommentRepository
    {
        public CommentRepository(CommentContext context) : base(context)
        {
        }

        public IEnumerable<Models.Comment> GetByPostId(Guid postId)
        {
            return context.Set<Models.Comment>().Where(comment => comment.PostId == postId);
        }
    }
}

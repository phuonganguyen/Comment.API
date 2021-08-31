using System;
using System.Collections.Generic;
using Comment.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Comment.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository commentRepository;

        public CommentController(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        [HttpGet]
        [Route("{postId}")]
        public IEnumerable<Models.Comment> GetComment(Guid postId)
        {
            return commentRepository.GetByPostId(postId);
        }


        [HttpPost]
        [Route("")]
        public void AddComment([FromBody] Models.Comment comment) => commentRepository.Insert(comment);
    }
}

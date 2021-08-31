using System;
using System.ComponentModel.DataAnnotations;

namespace Comment.API.Models
{
    public class Comment : BaseEntity
    {
        [Required]
        public Guid PostId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Content { get; set; }
    }
}

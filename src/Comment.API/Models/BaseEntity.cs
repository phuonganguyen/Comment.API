using System;
using System.ComponentModel.DataAnnotations;

namespace Comment.API.Models
{

    public interface IEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }

    public class BaseEntity : IEntity
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}

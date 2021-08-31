using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Comment.API.Data
{
    public class CommentEntityConfiguration : IEntityTypeConfiguration<Models.Comment>
    {
        public void Configure(EntityTypeBuilder<Models.Comment> builder)
        {
            builder.ToTable("Comment");
            builder.HasKey(c => c.Id);
        }
    }
}

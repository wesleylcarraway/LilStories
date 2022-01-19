using LilStoriesAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LilStoriesAPI.Map
{
    public class StoryMap : BaseMap<Story>
    {
        public StoryMap() : base("tb_story")
        {
        }

        public override void Configure(EntityTypeBuilder<Story> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Title).HasColumnName("title").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Genre).HasColumnName("genre").IsRequired();
            builder.Property(x => x.Author).HasColumnName("author").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Content).HasColumnName("content").IsRequired();
        }
    }
}

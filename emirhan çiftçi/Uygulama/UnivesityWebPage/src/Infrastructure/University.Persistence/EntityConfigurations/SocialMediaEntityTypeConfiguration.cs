using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Domain.Models;
using University.Persistence.Context;

namespace University.Persistence.EntityConfigurations
{
    public class SocialMediaEntityTypeConfiguration : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.ToTable("socialMedias", UniversityDbContext.DEFAULT_SCHEMA);

            builder.HasKey(b => b.Id);

            builder.Ignore(b => b.DomainEvents);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();

        }
    }
}

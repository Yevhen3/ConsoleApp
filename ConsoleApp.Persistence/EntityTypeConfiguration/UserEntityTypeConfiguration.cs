using ConsoleApp.Persistence.entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp.Persistence.EntityTypeConfiguration;

public class UserEntityTypeConfiguration:IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.email).IsRequired();
        builder.Property(x => x.Fullname).IsRequired();

    }
}
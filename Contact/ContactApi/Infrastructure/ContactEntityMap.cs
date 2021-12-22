using ContactApi.Services.CreateOrUpdateContact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactApi.Infrastructure
{
    public class ContactEntityMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("CONTACT");

            builder.HasKey(x => x.ContactId).HasName("ID");
            builder.Property(x => x.Name).HasColumnName("NAME");
            builder.Property(x => x.Email).HasColumnName("EMAIL");
            builder.Property(x => x.PhoneNumber).HasColumnName("PHONE_NUMBER");
        }
    }
}

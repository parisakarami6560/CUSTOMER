using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myblogef.Migrations;
using myblogef.Models;

namespace myblogef.Data.Config
{
    public class UserConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
           
            builder.Property(u =>u.FirstName).IsUnicode();
            builder.Property(u =>u.LastName).IsUnicode();
            builder.Property(u =>u.Email).IsUnicode();
            builder.Property(u=>u.PhoneNumber).HasMaxLength(12);   
        
            builder.Property(u => u.Age).HasComputedColumnSql("DATEDIFF(year,DateofBrith,GETDATE()) ");
        }
    }
}

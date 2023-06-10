
using LogisticsVersta24.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LogisticsVersta24.Persistance
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(order => order.Id);
            builder.HasIndex(order => order.Id).IsUnique();

            builder.Property(order => order.FromCity)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(order => order.FromAddress)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(order => order.ToCity)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(order => order.ToAddress)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(order => order.WeightInGrams)
                .IsRequired();

            builder.Property(order => order.ReceivedDate)
                .IsRequired();

        }
    }
}

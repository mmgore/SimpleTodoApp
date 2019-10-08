using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Domain.Entites;

namespace TodoApp.Infrastructure.EntityConfigration
{
    public class TodoEntityTypeConfigration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(25);

            builder.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(15);
        }
    }
}

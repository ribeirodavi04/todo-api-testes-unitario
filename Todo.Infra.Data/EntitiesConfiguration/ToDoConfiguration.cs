using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Domain.Entities;

namespace Todo.Infra.Data.EntitiesConfiguration
{
    public class ToDoConfiguration : IEntityTypeConfiguration<TaskToDo>
    {    
        public void Configure(EntityTypeBuilder<TaskToDo> builder)
        {
            builder.ToTable("Task");
            builder.HasKey(t => t.IdTask);
            builder.Property(t => t.Title).IsRequired();
            builder.Property(t => t.Description);
            builder.Property(t => t.Created).IsRequired();
            builder.Property(t => t.Status).IsRequired();
            builder.Property(t => t.IsCompleted).IsRequired();
        }
    }
}

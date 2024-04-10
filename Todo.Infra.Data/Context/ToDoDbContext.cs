using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Domain.Entities;

namespace Todo.Infra.Data.Context
{
    public class ToDoDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<TaskToDo> Tasks { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options, IConfiguration configuration) : base(options) 
        { 
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ToDoDbContext).Assembly);
        }
    }
}

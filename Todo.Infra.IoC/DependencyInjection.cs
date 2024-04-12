using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Application.Interfaces;
using Todo.Application.Mappins;
using Todo.Application.Services;
using Todo.Domain.Interfaces;
using Todo.Infra.Data.Context;
using Todo.Infra.Data.Repositories;

namespace Todo.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<ToDoDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            //repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            //services
            services.AddScoped<ITaskToDoService, TaskToDoService>();

            return services;
        }
    }
}

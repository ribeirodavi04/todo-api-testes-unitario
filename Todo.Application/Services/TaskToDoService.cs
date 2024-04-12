using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Application.Interfaces;
using Todo.Domain.Entities;
using Todo.Domain.Interfaces;

namespace Todo.Application.Services
{
    public class TaskToDoService : ITaskToDoService
    {
        public readonly IGenericRepository<TaskToDo> repositoryTask;
        public readonly IMapper _mapper;

        public TaskToDoService(IGenericRepository<TaskToDo> repositoryTask, IMapper mapper)
        {
            this.repositoryTask = repositoryTask;
            _mapper = mapper;
        }
    }
}

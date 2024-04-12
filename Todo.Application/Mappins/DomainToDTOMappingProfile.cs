using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Application.DTOs;
using Todo.Domain.Entities;

namespace Todo.Application.Mappins
{
    public class DomainToDTOMappingProfile :Profile
    {
        public DomainToDTOMappingProfile() 
        { 
            CreateMap<TaskToDo, TaskToDoDTO>().ReverseMap();
        }
    }
}

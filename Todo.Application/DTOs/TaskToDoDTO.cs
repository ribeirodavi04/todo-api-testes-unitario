using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Application.DTOs
{
    public class TaskToDoDTO
    {
        public int IdTask { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
        public bool IsCompleted { get; set; }
    }
}

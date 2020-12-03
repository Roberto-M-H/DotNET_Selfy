using System.ComponentModel.DataAnnotations;
using System;

namespace API.Entities
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public bool IsDone { get; set; } 
    }
}
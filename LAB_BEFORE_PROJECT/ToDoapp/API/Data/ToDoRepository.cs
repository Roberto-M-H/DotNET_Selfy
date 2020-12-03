using API.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Data
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly DataContext context;

        public ToDoRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(ToDo todo)
        {
            this.context.Add(todo);
            this.context.SaveChanges();
        }

        public void Update(ToDo todo)
        {
            this.context.Update(todo);
            this.context.SaveChanges();
        }

        public IEnumerable<ToDo> GetAll()
        {
            return this.context.ToDos.ToList();
        }

        public ToDo GetById(int id)
        {
            return this.context.ToDos.Find(id);
        }


        public IEnumerable<ToDo> GetActives()
        {
            return this.context.ToDos.Where(c=>c.IsDone == false).ToList();
        }

         public IEnumerable<ToDo> GetDone()
        {
            return this.context.ToDos.Where(c=>c.IsDone == true).ToList();
        }
        
        public void Remove(int id)
        {
            this.context.Remove(GetById(id));
            this.context.SaveChanges();
        }


    }
}

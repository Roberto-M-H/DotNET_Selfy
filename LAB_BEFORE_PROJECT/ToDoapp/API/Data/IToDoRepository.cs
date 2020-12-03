using API.Entities;
using System.Collections.Generic;

namespace API.Data
{
    public interface IToDoRepository
    {
        void Create(ToDo todo);
        IEnumerable<ToDo> GetAll();
        ToDo GetById(int id);

       IEnumerable<ToDo> GetActives();

       IEnumerable<ToDo> GetDone();

        void Remove(int id);
        void Update(ToDo todo);
    }
}
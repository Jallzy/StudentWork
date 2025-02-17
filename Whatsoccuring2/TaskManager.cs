using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatsoccuring2
{
    internal class TaskManager
    {
        private List<Task> tasks = new List<Task>();


        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);

        }

        public List<Task> GetTasks()
        {
            return tasks;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Project
    {
        private readonly IList<Task> _tasks = new List<Task>();

        public void Add(Task task)
        {
            _tasks.Add(task);
        }

        public void PrintInto(IConsole console)
        {
            foreach (var task in _tasks)
            {
                var taskDone = task.Done;
                var taskIdentifier = task.Identifier;
                var taskDescription = task.Description;
                console.WriteLine($"    [{(taskDone ? 'x' : ' ')}] {taskIdentifier}: {taskDescription}");
            }
        }

        public void SetDoneIfExists(string identifier, bool done, IConsole console)
        {
            var identifiedTask = _tasks
                .FirstOrDefault(task => task.Identifier == long.Parse(identifier));

            if (identifiedTask != null) identifiedTask.Done = done;
        }
    }
}

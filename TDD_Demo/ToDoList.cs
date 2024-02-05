using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Demo;
public class ToDoList
{
    public List<string> Tasks { get; private set; } = new List<string>();

    public void AddTask(string task)
    {
        Tasks.Add(task);
    }
    public void MarkTaskAsCompleted(string task)
    {
        Tasks.Remove(task);
    }

}

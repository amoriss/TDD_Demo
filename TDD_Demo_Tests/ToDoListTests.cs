using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Demo;

namespace TDD_Demo_Tests;
public class ToDoListTests
{
    [Fact]
    public void AddTask_Test()
    {
        // Arrange
        var toDoList = new ToDoList();
        string newTask = "Finish TDD example";

        // Act
        toDoList.AddTask(newTask);

        // Assert
        Assert.Contains(newTask, toDoList.Tasks);
        Assert.Single(toDoList.Tasks);
    }

    [Theory]
    [InlineData("mowing the lawn")]
    [InlineData("taking out the trash")]
    public void AddTask_Test2(string newTask)
    {
        // Arrange
        var toDoList = new ToDoList();

        // Act
        toDoList.AddTask(newTask);

        // Assert
        Assert.Contains(newTask, toDoList.Tasks);
        Assert.Single(toDoList.Tasks);
    }


    [Fact]
    public void MarkTaskAsCompleted_Test()
    {
        // Arrange
        var toDoList = new ToDoList();
        string task = "Review TDD principles";
        toDoList.AddTask(task);

        // Act
        toDoList.MarkTaskAsCompleted(task);

        // Assert
        Assert.DoesNotContain(task, toDoList.Tasks);
    }
}

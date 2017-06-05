using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Xunit;

namespace ToDoList
{
  public class ToDoTest : IDisposable
  {
    public ToDoTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=toDoTest;Integrated Security=SSPI;";
    }

    public void Dispose()
    {
      Task.DeleteAll();
    }

    [Fact]
    public void Test_DataBaseIsEmpty()
    {
      int result = Task.GetAll().Count;
      Assert.Equal(0, result);
    }

    [Fact]
    public void Test_ReturnsTrueIfEqual()
    {
      Task task01 = new Task("Take out the trash");
      Task task02 = new Task("Take out the trash");

      //Assert
      Assert.Equal(task01, task02);
    }

    [Fact]
    public void Test_SavesDataBase()
    {
      Task task01 = new Task("Take out the trash");

      task01.Save();
      List<Task> testList = new List<Task>{task01};
      List<Task> result = Task.GetAll();

      //Assert
      Assert.Equal(testList, result);
    }

    [Fact]
    public void Test_FindObjectById()
    {
      //Arrange
      Task testTask = new Task("Mow the lawn");
      testTask.Save();

      //Act
      Task foundTask = Task.Find(testTask.GetId());

      //Assert
      Assert.Equal(testTask, foundTask);
    }
  }
}

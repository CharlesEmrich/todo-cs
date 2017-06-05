using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ToDoList
{
  public class ToDoTest : IDisposable
  {
    public ToDOTest()
    {
      DBConfigiuration.ConnectionSTring = "Data Source=(localdb\mssqllocaldb);Initial Catalog=todo_test;Integrated Security=SSPI;";
    }
    public class Dispose()
    {
      Task.DeleteAll();
    }
  }
}

using System.Collections.Generic;

namespace ToDoList
{
  public class Task
  {
    private string _description;
    private int _id;
    private static List<Task> _instances = new List<Task> {};

    public Task(string description)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count; //In doing this, ensures that each object has a unique ID.
    }

    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string d)
    {
      _description = d;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Task> GetAll()
    {
      return _instances;
    }
    public static void DeleteAll()
    {
      _instances.Clear(); //Destroy them.
    }
    public static Task Find(int searchId)
    {
      return _instances[searchId-1]; //List start at index[0],
    }
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ToDoList
    {
        public int ID;
        public string Name;

        public bool IsDone { get; internal set; } 

        // public string Name { get; set; }
    }
}






/*   internal class TodoTask
{
        public int ID { get; set; }
public string Name { get; set; } = string.Empty;
public bool IsDone { get; set; }



//////////////////////////
///

}
private bool _isDone;  // hidden real variable

public bool IsDone
{
    get
    {
        return _isDone;  // just reads it
    }
    set
    {
        // could add logic here to check before writing
        _isDone = value;
    }
}
     */
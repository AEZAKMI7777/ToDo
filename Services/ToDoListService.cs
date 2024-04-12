using System.Collections.Generic;
using ToDoList.DataModel;

namespace ToDoList.Services;

public class ToDoListService
{
    public IEnumerable<ToDoItem> GetItems() => new[]
    {
        new ToDoItem { Description = "Zbuduj apke jako tako" , IsChecked = true },
        new ToDoItem { Description = "Rozwiń apke " , IsChecked = false },
        new ToDoItem { Description = "Skompiluj żeby działała",  },
    };
}
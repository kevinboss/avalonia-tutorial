using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Todo.Models;

namespace Todo.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
        }

        public event EventHandler AddItemEvent;

        public ObservableCollection<TodoItem> Items { get; }

        public void AddItem()
        {
            AddItemEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
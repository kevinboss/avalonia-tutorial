using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using ReactiveUI;
using Todo.Models;

namespace Todo.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
            AddItem = ReactiveCommand.Create(() => { });
        }

        public ObservableCollection<TodoItem> Items { get; }
        
        public ReactiveCommand<Unit, Unit> AddItem { get; }
    }
}
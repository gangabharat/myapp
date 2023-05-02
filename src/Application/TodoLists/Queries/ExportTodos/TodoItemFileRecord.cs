using myapp.Application.Common.Mappings;
using myapp.Domain.Entities;

namespace myapp.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}

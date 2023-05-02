using myapp.Application.TodoLists.Queries.ExportTodos;

namespace myapp.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}

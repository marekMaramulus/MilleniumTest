namespace MilleniumTest.Services;

public interface ITodoService
{
    int Add(TodoItem item);
    TodoItem? Get(int itemId);
    IReadOnlyCollection<TodoItem> GetAll();
    ResultCodes Update(TodoItem item);
}
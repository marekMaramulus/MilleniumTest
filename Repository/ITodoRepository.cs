namespace MilleniumTest.Repository;

public interface ITodoRepository
{
    IReadOnlyCollection<TodoItem> GetAll();
    TodoItem? Get(int itemId);
    int Add(TodoItem item);
    bool Update(TodoItem item);
}
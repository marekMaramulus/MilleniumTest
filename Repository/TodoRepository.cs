namespace MilleniumTest.Repository;

public class TodoRepository : ITodoRepository
{
    private IStorageStub _stub;
    public TodoRepository(IStorageStub stub)
    {
        _stub = stub;
    }

    public int Add(TodoItem item)
    {
        item.Id = _stub.Storage().Count + 1;
        if (!_stub.Storage().TryAdd(item.Id, item))
        {
            return -1;
        };
        return item.Id;
    }

    public TodoItem? Get(int itemId)
    {
        if (!_stub.Storage().TryGetValue(itemId, out var existing))
        {
            return null;
        };
        return existing;
    }

    public IReadOnlyCollection<TodoItem> GetAll()
    {
        return _stub.Storage().Values.ToArray();
    }

    public bool Update(TodoItem item)
    {
        if (!_stub.Storage().TryGetValue(item.Id, out var existing))
        {
            return false;
        }

        return _stub.Storage().TryUpdate(item.Id, item, existing);
    }
};

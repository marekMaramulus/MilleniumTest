using System.Collections.Concurrent;

namespace MilleniumTest.Repository
{
    public interface IStorageStub
    {
        public ConcurrentDictionary<int, TodoItem> Storage();
    }

    internal class StorageStub : IStorageStub
    {
        private readonly ConcurrentDictionary<int, TodoItem> _todoItems = new();

        public ConcurrentDictionary<int, TodoItem> Storage()
        {
            return _todoItems;
        }
    }
}

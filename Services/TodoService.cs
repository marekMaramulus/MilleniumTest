using MilleniumTest.Repository;

namespace MilleniumTest.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            this._todoRepository = todoRepository;
        }

        public int Add(TodoItem item)
        {
            return _todoRepository.Add(item);
        }

        public TodoItem? Get(int itemId)
        {
            return _todoRepository.Get(itemId);
        }

        public IReadOnlyCollection<TodoItem> GetAll()
        {
            return _todoRepository.GetAll();
        }

        public ResultCodes Update(TodoItem item)
        {
            var oldItem = _todoRepository.Get(item.Id);
            if (oldItem is null)
            {
                return ResultCodes.ItemNotFound;
            }

            if (oldItem.IsFinished && !item.IsFinished)
            {
                return ResultCodes.CannotChangeStatusOfFinishedItem;
            }

            item.LastChangeDate = DateTime.UtcNow;
            if (!_todoRepository.Update(item))
            {
                return ResultCodes.ItemNotFound;
            }
            return ResultCodes.Success;
        }
    }
}

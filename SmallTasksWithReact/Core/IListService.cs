using System.Collections.Generic;

namespace SmallTasksWithReact.Core
{
    public interface IListService
    {
        List<int> AddLists(List<int> numberOne, List<int> numberTwo);
    }
}
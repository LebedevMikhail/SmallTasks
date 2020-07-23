using System.Collections.Generic;
using SmallTasksWithReact.Core;

namespace SmallTasksWithReact.Services
{
    public class ListService : IListService
    {
        public List<int> AddLists(List<int> numberOne, List<int> numberTwo)
        {
            if (numberOne == null || numberTwo == null)
            {
                return new List<int>();
            }

            var result = new List<int>();

            var isNeedPlusOne = false;
            var minLength = numberOne.Count > numberTwo.Count ? numberTwo.Count : numberOne.Count;
            var isFirstListSmall = minLength == numberOne.Count && numberTwo.Count > numberOne.Count;
            for (var i = 0; i < minLength; i++)
            {
                var node = numberOne[i] + numberTwo[i];
                if (isNeedPlusOne)
                {
                    node++;
                    isNeedPlusOne = false;
                }

                if (node < 10) result.Add(node);
                else
                {
                    isNeedPlusOne = true;
                    result.Add(node - 10);
                }
            }

            if (isFirstListSmall)
            {
                for (var i = numberOne.Count; i < numberTwo.Count; i++)
                {
                    result.Add(numberTwo[i]);
                }
            }
            else
            {
                for (var i = numberTwo.Count; i < numberOne.Count; i++)
                {
                    result.Add(numberOne[i]);
                } 
            }

                     
            return result;
        }
    }
}
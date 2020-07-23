using SmallTasksWithReact.Core;
using SmallTasksWithReact.Core.DTO;

namespace SmallTasksWithReact.Services
{
    public class StringService : IStringService
    {
        public bool IsPalindrome(CheckPalindromeDto input)
        {
            if (input?.Query == null) return false;
            var min = 0;
            var max = input.Query.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }

                var a = input.Query[min];
                var b = input.Query[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }

                min++;
                max--;
            }
        }
    }
}
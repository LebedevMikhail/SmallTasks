using SmallTasksWithReact.Core.DTO;

namespace SmallTasksWithReact.Core
{
    public interface IStringService
    {
        bool IsPalindrome(CheckPalindromeDto input);
    }
}
using NUnit.Framework;
using SmallTasksWithReact.Core;
using SmallTasksWithReact.Core.DTO;
using SmallTasksWithReact.Services;

namespace SmallTasksWithReact.Tests.ServicesTests
{
    public class StringServiceTest
    {
        private IStringService _service;

        [SetUp]
        public void Setup()
        {
            _service = new StringService();
        }
        
        [Test]
        public void CorrectPalindrome_ShouldReturnTrue()
        {
            const string query = "qwertyytrewq";
            var result = _service.IsPalindrome(new CheckPalindromeDto(query));
            Assert.AreEqual(result, true);
        }
        
        [Test]
        public void IncorrectPalindrome_ShouldReturnFalse()
        {
            const string query = "qwerty";
            var result = _service.IsPalindrome(new CheckPalindromeDto(query));
            Assert.AreEqual(result, false);
        }
        
        [Test]
        public void Null_ShouldReturnFalse()
        {
            const string query = null;
            var result = _service.IsPalindrome(new CheckPalindromeDto(query));
            Assert.AreEqual(result, false);
        }
    }
}
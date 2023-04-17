using FluentAssertions;
using GemsDev.GemsDev;
using System.ComponentModel.Design;

namespace GemsDev.Tests
{
    public class GemsDevTests
    {
        [Theory]
        [InlineData("2", true)]
        [InlineData("dfsa", false)]
        [InlineData("f23214", false)]
        [InlineData(" f  f", false)]
        [InlineData(" ", false)]
        [InlineData("2 ", true)]
        [InlineData("       2 ", true)]
        public void GivenStr_ThenReturnsCheckThatStrIsNumber(string str, bool expected)
        {
            var result = GemsDev.ConsoleInputValidation.InputValidation(str);
            result.Should().Be(expected);
        }        
    }
}
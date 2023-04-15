using FluentAssertions;
using System.ComponentModel.Design;

namespace GemsDev.Tests
{
    public class GemsDevTests
    {
     
        [Theory]
        [InlineData(2, -9, 7, 1)]
        [InlineData(2, 1, -1, -1)]
        [InlineData(71, 144, 4, (double)-2)]
        [InlineData(-6, 0, 54, 3)]
        [InlineData(3, -4, 94, double.NaN)]
         public void Given3RealNumbersAsCoefForQuadEquation_ThenReturnsFirstRootOfQuadEquationAsResult(double Coef1, double Coef2, double Coef3, double expected)
        {
            var result = GemsDev.QuadEqCalc.SolveQEqNegRoot(Coef1, Coef2, Coef3);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, -9, 7, 3.5)]
        [InlineData(2, 1, -1, 0.5)]
        [InlineData(71, 144, 4, -((double)2 / 71))]
        [InlineData(-6, 0, 54, -3)]
        [InlineData(3, -4, 94, double.NaN)]       
         public void Given3RealNumbersAsCoefForQuadEquation_ThenReturnsSecondRootOfQuadEquationAsResult(double Coef1, double Coef2, double Coef3, double expected)
        {
            var result = GemsDev.QuadEqCalc.SolveQEqPosRoot(Coef1, Coef2, Coef3);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 4, 2, 0)]
        [InlineData(25, 30, 8, 100)]
        public void Given3RealNumbersAsCoefForQuadEquation_ThenReturnsDiscriminantAsResult(double Coef1, double Coef2, double Coef3, double expected)
        {
            var result = GemsDev.QuadEqCalc.SolveDiscriminant(Coef1, Coef2, Coef3);
            result.Should().Be(expected);
        }

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
            var result = GemsDev.Validation.InputValidation(str);
            result.Should().Be(expected);
        }
         
    }
}
using FluentAssertions;
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
            var result = QuadEqCalc.SolveQEqNegRoot(Coef1, Coef2, Coef3);
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
            var result = QuadEqCalc.SolveQEqPosRoot(Coef1, Coef2, Coef3);
            result.Should().Be(expected);
        }
         
    }
}
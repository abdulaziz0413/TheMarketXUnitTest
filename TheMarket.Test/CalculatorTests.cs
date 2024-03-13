
using FluentAssertions;
namespace TheMarket.Test;

public class CalculatorTests
{
    [Theory]
    [InlineData(1,2)]
    [InlineData(2,3)]
    [InlineData(3,4)]
    [InlineData(4,5)]
    [InlineData(5,6)]
    public void AddTest(int a, int b)
    {
        Calculator calculator = new Calculator();
        var result = calculator.Add(a, b);
        result.Should().Be(a+b);
    }
    [Fact]
    public void Divide()
    {
        Calculator calculator = new Calculator();
        var result = calculator.Divide(4, 2);
        result.Should().Be(4/2);
        
    }

    [Fact]
    public void Subtract()
    {
        Calculator calculator = new Calculator();
        var  result = calculator.Subtract(4, 2);
        result.Should().Be(4-2);
    }
    [Fact] 
    public void Multiply()
    {
        Calculator calculator = new Calculator();
        var result  = calculator.Multiply(4, 2);
        result.Should().Be(4*2);
    }

}

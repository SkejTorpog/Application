using System;
using Xunit;
using WpfApp6;

namespace App.UnitTests
{
    public class FunctionTests
    {
        [Fact]
        public void TestCalculateFunction()
        {
            // Arrange
            Function function1 = new Function() { Name = "Линейная", A = 3, B = 4, C = 5, X = 1, Y = 9};
            Function function2 = new Function() { Name = "Квадратичная", A = 3, B = 4, C = 5, X = 1, Y = 9};
            Function function3 = new Function() { Name = "Кубическая", A = 3, B = 4, C = 5, X = 1, Y = 9};
            Function function4 = new Function() { Name = "4-ой степени", A = 3, B = 4, C = 5, X = 1, Y = 9};
            Function function5 = new Function() { Name = "5-ой степени", A = 3, B = 4, C = 5, X = 1, Y = 9};

            // Act
            function1.CalculateFunction();
            function2.CalculateFunction();
            function3.CalculateFunction();
            function4.CalculateFunction();
            function5.CalculateFunction();

            var Fxy1 = 3 * 1 + 4 * 1 + 5; // Fxy = A * X + B * 1 + C;
            var Fxy2 = 3 * (int)Math.Pow(1, 2) + 4 * 9 + 5; // Fxy = A * (int)Math.Pow(X, 2) + B * Y + C;
            var Fxy3 = 3 * (int)Math.Pow(1, 3) + 4 * (int)Math.Pow(9, 2) + 5; // Fxy = A * (int)Math.Pow(X, 3) + B * (int)Math.Pow(Y, 2) + C;
            var Fxy4 = 3 * (int)Math.Pow(1, 4) + 4 * (int)Math.Pow(9, 3) + 5; // Fxy = A * (int)Math.Pow(X, 4) + B * (int)Math.Pow(Y, 3) + C;
            var Fxy5 = 3 * (int)Math.Pow(1, 5) + 4 * (int)Math.Pow(9, 4) + 5; // Fxy = A * (int)Math.Pow(X, 5) + B * (int)Math.Pow(Y, 4) + C;

            // Assert
            Assert.Equal(Fxy1, function1.Fxy);
            Assert.Equal(Fxy2, function2.Fxy);
            Assert.Equal(Fxy3, function3.Fxy);
            Assert.Equal(Fxy4, function4.Fxy);
            Assert.Equal(Fxy5, function5.Fxy);
        }
    }
}

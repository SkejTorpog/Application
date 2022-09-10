using System;
using Xunit;
using App.Models;

namespace App.UnitTests
{
    public class FunctionTests
    {
        [Fact]
        public void TestCalculateFunction()
        {
            // Arrange
            var function1 = new Function() { Name = "Линейная", A = 3, B = 4, C = 5, X = 1, Y = 9};
            var function2 = new Function() { Name = "Квадратичная", A = 3, B = 4, C = 5, X = 1, Y = 9};
            var function3 = new Function() { Name = "Кубическая", A = 3, B = 4, C = 5, X = 1, Y = 9};
            var function4 = new Function() { Name = "4-ой степени", A = 3, B = 4, C = 5, X = 1, Y = 9};
            var function5 = new Function() { Name = "5-ой степени", A = 3, B = 4, C = 5, X = 1, Y = 9};

            // Act
            function1.CalculateFunction();
            function2.CalculateFunction();
            function3.CalculateFunction();
            function4.CalculateFunction();
            function5.CalculateFunction();

            var fxy1 = 3 * 1 + 4 * 1 + 5; // Fxy = A * X + B * 1 + C;
            var fxy2 = 3 * (int)Math.Pow(1, 2) + 4 * 9 + 5; // Fxy = A * (int)Math.Pow(X, 2) + B * Y + C;
            var fxy3 = 3 * (int)Math.Pow(1, 3) + 4 * (int)Math.Pow(9, 2) + 5; // Fxy = A * (int)Math.Pow(X, 3) + B * (int)Math.Pow(Y, 2) + C;
            var fxy4 = 3 * (int)Math.Pow(1, 4) + 4 * (int)Math.Pow(9, 3) + 5; // Fxy = A * (int)Math.Pow(X, 4) + B * (int)Math.Pow(Y, 3) + C;
            var fxy5 = 3 * (int)Math.Pow(1, 5) + 4 * (int)Math.Pow(9, 4) + 5; // Fxy = A * (int)Math.Pow(X, 5) + B * (int)Math.Pow(Y, 4) + C;

            // Assert
            Assert.Equal(fxy1, function1.Fxy);
            Assert.Equal(fxy2, function2.Fxy);
            Assert.Equal(fxy3, function3.Fxy);
            Assert.Equal(fxy4, function4.Fxy);
            Assert.Equal(fxy5, function5.Fxy);
        }
    }
}

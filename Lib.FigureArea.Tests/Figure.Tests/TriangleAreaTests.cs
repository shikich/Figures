namespace Lib.FigureArea.Tests.Figure.Tests;

public class TriangleAreaTests
{
    [Fact]
    public void CheckIsRightAngled_ValidSides_ReturnsTrue()
    {
        // Arrange
        var fside = 3.0;
        var sside = 4.0;
        var hypotenuse = 5.0;

        // Act
        var isRightAngled = TriangleArea.CheckIsRightAngled(fside, sside, hypotenuse);

        // Assert
        Assert.True(isRightAngled);
    }

    [Fact]
    public void CheckIsRightAngled_InvalidSides_ReturnsFalse()
    {
        // Arrange
        var fside = 3.0;
        var sside = 4.0;
        var hypotenuse = 6.0;

        // Act
        var isRightAngled = TriangleArea.CheckIsRightAngled(fside, sside, hypotenuse);

        // Assert
        Assert.False(isRightAngled);
    }

    [Fact]
    public void ExecuteAreaByThreeSides_ValidSides_ReturnsArea()
    {
        // Arrange
        var fside = 3.0;
        var sside = 4.0;
        var tside = 5.0;

        // Act
        var area = TriangleArea.ExecuteAreaByThreeSides(fside, sside, tside);

        // Assert
        Assert.Equal(6.0, area);
    }

    [Fact]
    public void ExecuteAreaByThreeSides_InvalidSides_ThrowsArgumentException()
    {
        // Arrange
        var fside = -1.0;
        var sside = 4.0;
        var tside = 5.0;

        // Act
        var area = TriangleArea.ExecuteAreaByThreeSides(fside, sside, tside);

        // Assert
        Assert.Equal(0, area);
    }
}

namespace Lib.FigureArea.Tests.Figure.Tests;

public class CircleAreaTests
{
    [Fact]
    public void ExecuteAreaByRadius_ValidRadius_ReturnsArea()
    {
        // Arrange
        var radius = 5.0;

        // Act
        var area = CircleArea.ExecuteAreaByRadius(radius);

        // Assert
        Assert.Equal(78.5398, Math.Round(area, 4));
    }

    [Fact]
    public void ExecuteAreaByRadius_InvalidRadius_ThrowsArgumentException()
    {
        // Arrange
        var radius = -1.0;

        // Act
        var area = CircleArea.ExecuteAreaByRadius(radius);

        // Assert
        Assert.Equal(0, area);
    }
}

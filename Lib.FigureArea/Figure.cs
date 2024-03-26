namespace Lib.FigureArea;

public static class CircleArea
{
    public static double ExecuteAreaByRadius(double radius)
    {
        // Проверка на zero/negative
        if (radius <= 0)
            return 0;

        return Math.PI * Math.Pow(radius, 2);
    }
}

public static class TriangleArea
{
    public static bool CheckIsRightAngled(double fside, double sside, double hypotenuse)
    {
        // Проверка на zero/negative
        if (fside <= 0 || sside <= 0 || hypotenuse <= 0)
            return false;

        // Проверка на существование треугольника
        if (fside + sside <= hypotenuse)
            return false;

        // Проверка на прямоугольность
        return Math.Pow(hypotenuse, 2) == Math.Pow(fside, 2) + Math.Pow(sside, 2);
    }

    public static double ExecuteAreaByThreeSides(double fside, double sside, double tside)
    {
        if (fside <= 0 || sside <= 0 || tside <= 0)
            return 0;

        if (fside + sside <= tside)
            return 0;

        var halfMeter = (fside + sside + tside) / 2;

        //Расчёт площади треугольника по формуле 'Герона'
        return Math.Sqrt(halfMeter * (halfMeter - fside) * (halfMeter - sside) * (halfMeter - tside));
    } 
}


using JetBrains.Annotations;

namespace MainForm;

[PublicAPI]
public class TriangleCalculations
{
    /// <summary>
    /// Проверка возможности существования треугольника
    /// </summary>
    /// <param name="triangle">Объект треугольника <see cref="Triangle"/></param>
    /// <returns>True - если треугольник возможен, иначе False</returns>
    public static bool ValidateTriangle(Triangle triangle)
    {
        if (triangle.A >= triangle.B + triangle.C)
            return false;
        
        if (triangle.B >= triangle.A + triangle.C)
            return false;
        
        if (triangle.C >= triangle.A + triangle.B)
            return false;
        
        return true;
    }
    
    /// <summary>
    /// Вычисление площади треугольника через три стороны
    /// </summary>
    /// <param name="triangle">Объект треугольника <see cref="Triangle"/></param>
    /// <returns>Площадь треугольника</returns>
    public static double GetTriangleArea(Triangle triangle)
    {
        if (!ValidateTriangle(triangle))
            throw new ArgumentException($"Треугольник {nameof(triangle)} невозможен. ");
        
        double halfPerimeter = (triangle.A + triangle.B + triangle.C)/2; 
        return Math.Sqrt(halfPerimeter * (halfPerimeter - triangle.A) * (halfPerimeter - triangle.B) * (halfPerimeter - triangle.C));
    }


    /// <summary>
    /// Вычисляет углы треугольника по его сторонам
    /// </summary>
    /// <param name="triangle">Объект треугольника <see cref="Triangle"/></param>
    /// <returns>Массив размером 3, содержащий все углы треугольника</returns>
    public static double[] GetTriangleAngles(Triangle triangle)
    {
        if (!ValidateTriangle(triangle))
            throw new ArgumentException($"Треугольник {nameof(triangle)} невозможен. ");
        
        var firstAngle = Math.Acos((Math.Pow(triangle.A, 2) + Math.Pow(triangle.C, 2) - Math.Pow(triangle.B, 2))
                                   /(2 * triangle.A * triangle.C));
        var secondAngle = Math.Acos((Math.Pow(triangle.A, 2) + Math.Pow(triangle.B, 2) - Math.Pow(triangle.C, 2))
                                   /(2 * triangle.A * triangle.B));
        
        var thirdAngle = Math.Acos((Math.Pow(triangle.B, 2) + Math.Pow(triangle.C, 2) - Math.Pow(triangle.A, 2))
                                    /(2 * triangle.C * triangle.B));
        return [firstAngle, secondAngle, thirdAngle];
    }

    /// <summary>
    /// Вычисляет высоты треугольника по его сторонам
    /// </summary>
    /// <param name="triangle">Объект треугольника <see cref="Triangle"/></param>
    /// <returns>Массив размером 3, содержащий высоты треугольника</returns>
    public static double[] GetTriangleHeights(Triangle triangle)
    {
        var triangleArea = GetTriangleArea(triangle); // Не будем проверять на ValidateTriangle, так как тут уже есть проверка
        var firstHeight = 2 * triangleArea / triangle.A;
        var secondHeight = 2 * triangleArea / triangle.B;
        var thirdHeight = 2 * triangleArea / triangle.C;

        return [firstHeight, secondHeight, thirdHeight];
    }
    
    private double RadiansToDegrees(double radian)
    {
        return radian * 180 / Math.PI;
    }

    private double DegreesToRadians(double degree)
    {
        return degree * Math.PI / 180;
    }
}

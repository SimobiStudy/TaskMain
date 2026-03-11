using JetBrains.Annotations;

namespace MainForm;

[PublicAPI]
public class TrianglePerimeter
{
    /// <summary>
    /// Вычисление площади треугольника через три стороны
    /// </summary>
    /// <param name="triangle">Объект <see cref="Triangle"/></param>
    /// <returns>Площадь треугольника</returns>
    public static double GetTriangleArea(Triangle triangle)
    {
        if (!VariantTask.ValidateTriangle(triangle))
            throw new ArgumentException($"Треугольник {nameof(triangle)} невозможен. ");
        
        double halfPerimeter = (triangle.A + triangle.B + triangle.C)/2; 
        return Math.Sqrt(halfPerimeter * (halfPerimeter - triangle.A) * (halfPerimeter - triangle.B) * (halfPerimeter - triangle.C));
    }
    
    /// <summary>
    /// Вычисление площади треугольника через сторону и два прилежащих к ней углов
    /// </summary>
    /// <param name="side">Сторона треугольника</param>
    /// <param name="angle1">Первый прилежащий угол к треугольнику в радианах</param>
    /// <param name="angle2">Второй прилежащий угол к треугольнику в радианах</param>
    /// <returns>Площадь треугольника</returns>
    public static double GetTriangleAreaSideAndTwoAngles(double side, double angle1, double angle2)
    {
        if (angle1 + angle2 >= 180)
            throw new ArgumentException("Сумма углов больше 180 градусов");
        
        return Math.Pow(side, 2) * Math.Sin(angle1) * Math.Sin(angle2);
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

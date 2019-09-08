using System;

namespace Triangles
{
    public class TriangleUtils
    {
    public enum TriangleType
    {
      ACUTE, // остроугольный
      RIGHT, // прямоугольный
      OBTUSE, // тупоугольный
    }
    public TriangleType GetTriangleType(double a, double b, double c)
    {
      double result = Math.Pow(b, 2.0) + Math.Pow(c, 2.0) - Math.Pow(a, 2.0);
      TriangleType type = TriangleType.RIGHT;
      if (result > 0)
      {
        type = TriangleType.ACUTE;
      }
      else if (result < 0)
      {
        type = TriangleType.OBTUSE;
      }
      return type;
    }
  }
}

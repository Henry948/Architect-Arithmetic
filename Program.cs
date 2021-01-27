using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // to store and calculate the rectangle area of floor plan

      Console.Write("please enter the rectangle length: ");
      double rectangleLength = Console.ReadLine();
      Console.Write("Please enter the height of the rectangle: ");
      double rectangleHeight = Console.ReadLine();
      double rectangleArea = Rectangles(rectangleLength, rectangleHeight);

      // to store and calculate the circle area in the floor plan

      Console.Write("please enter the radius of the circle: ")
      double circleRadius = Console.ReadLine();
      Console.Write("Is this a semi-circle> YES / NO");
      string answer = Console.ReadLine();
      answer.ToUpper();
      double circleArea;
      if (answer = "YES") {
        circleArea = Circles(CircleRadius) / 2;
      } else {
        circleArea = Circles(CircleRadius);
      }
      // to store and calculate the triangle area on the floor plan

      Console.Write("Enter the bottom value of the triangle: ");
      double triangleBottom = Console.ReadLine();
      Console.Write("Enter the height value of the triangle: ");
      double triangleHeight = Console.ReadLine();
      double trianglearea = Triangles(triangleBottom, traingleHeight);

      // total area is calculated below

      double floorPlanArea = rectangleArea + circleArea + triangleArea;
      Console.WriteLine($"The area of the complete floorplan is {floorPlanArea}m²");

      // The code below calculates the cost in gbp per square meter
      int pricePerSqareMeter = 50;
      bool floorPlanPrice = pricePerSquareMeter * floorPlanArea;
      Console.WriteLine($"The total price for the flooring will cost {floorPlanPrice} to cover {floorPlanArea}m²");
    }

    static double Rectangles(double length, double width) {
      return length * width;
    }
    static double Circles(double radius){
       return Math.PI * Math.Pow(radius, 2);
    }
    static double Triangles(double bottom, double height) {
      return 0.5 * bottom * height;
    }
  }
}

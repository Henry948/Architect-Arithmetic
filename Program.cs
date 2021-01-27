using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
       // to store and calculate the rectangle area of floor plan

      Console.Write("please enter the rectangle length: ");
      string rectangleLength = Console.ReadLine();
      Convert.ToDouble(rectangleLength);
      Console.Write("Please enter the height of the rectangle: ");
      string rectangleHeight = Console.ReadLine();
      Convert.ToDouble(rectangleHeight);
      double rectangleArea = Rectangles(rectangleLength, rectangleHeight);


      // to store and calculate the circle area in the floor plan

      Console.Write("please enter the radius of the circle: ");
      string circleRadius = Console.ReadLine();
      Convert.ToDouble(circleRadius);
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
      string triangleBottom = Console.ReadLine();
      Convert.ToDouble(triangleBottom);
      Console.Write("Enter the height value of the triangle: ");
      string triangleHeight = Console.ReadLine();
      Convert.ToDouble(triangleHeight);
      double trianglearea = Triangles(triangleBottom, traingleHeight);

      // total area is calculated below

      double floorPlanArea = rectangleArea + circleArea + triangleArea;
      Console.WriteLine($"The area of the complete floorplan is {floorPlanArea}m²");

      // The code below calculates the cost in gbp per square meter
      int pricePerSqareMeter = 50;
      double floorPlanPrice = pricePerSquareMeter * floorPlanArea;
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

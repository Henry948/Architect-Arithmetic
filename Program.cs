using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
       RectangleArea();

      // to store and calculate the circle area in the floor plan

      Console.Write("please enter the radius of the circle: ");
      string circleRadius = Console.ReadLine();
      Convert.ToDouble(circleRadius);
      Console.Write("Is this a semi-circle> YES / NO");
      string answer = Console.ReadLine();
      answer.ToUpper();
      double circleArea;
      if (answer == "YES") {
        circleArea = Circles(circleRadius) / 2;
      } else {
        circleArea = Circles(circleRadius);
      }
      // to store and calculate the triangle area on the floor plan

      Console.Write("Enter the bottom value of the triangle: ");
      string triangleBottom = Console.ReadLine();
      double triBottomAsDouble = Convert.ToDouble(triangleBottom);
      Console.Write("Enter the height value of the triangle: ");
      double triHeightAsDouble = string triangleHeight = Console.ReadLine();
      Convert.ToDouble(triangleHeight);
      double trianglearea = Triangles(triBottomAsDouble, triHeightAsDouble);

      // total area is calculated below

      double floorPlanArea = rectangleArea + circleArea + triangleArea;
      Console.WriteLine($"The area of the complete floorplan is {floorPlanArea}m²");

      // The code below calculates the cost in gbp per square meter
      int pricePerSqareMeter = 50;
      double floorPlanPrice = pricePerSquareMeter * floorPlanArea;
      Console.WriteLine($"The total price for the flooring will cost {floorPlanPrice} to cover {floorPlanArea}m²");
    }

     // to store and calculate the rectangle area of floor plan
    static double RectangleArea(double rectangleLength, double rectangleHeight) 
    {
      Console.Write("please enter the rectangle length: ");
      rectangleLength = Console.ReadLine();
      double recLengthAsDouble = Convert.ToDouble(rectangleLength);
      Console.Write("Please enter the height of the rectangle: ");
      double recHeightAsDouble = rectangleHeight = Console.ReadLine();
      Convert.ToDouble(rectangleHeight);
      return Rectangles(rectangleLength, rectangleHeight);
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

using System;
using System.Linq;
namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {

      int numberOfRectangles;
      int numberOfCircles;
      int numberOfTriangles;

      double[] rectangleAreaArray = new double[] {0};
      double[] circleAreaArray = new double[] {0};
      double[] triangleAreaArray = new double[] {0};

     // to store and calculate the rectangle area of floor plan
     Console.Write("How many rectangles are in the floor plan? ");
     string numberOfRectanglesAsString = Console.ReadLine();
     numberOfRectangles =  Convert.ToInt32(numberOfRectanglesAsString);

     while (numberOfRectangles > 0) {
        Console.Write("please enter the rectangle length: ");
        double rectangleLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Please enter the height of the rectangle: ");
        double rectangleHeight =  Convert.ToDouble(Console.ReadLine());
        Convert.ToDouble(rectangleHeight);
        double rectangleArea = Rectangles(rectangleLength, rectangleHeight);
        rectangleAreaArray = rectangleAreaArray.Concat(new double[] {rectangleArea}).ToArray();
        numberOfRectangles--;
      }

      double totalRectangleArea = rectangleAreaArray.Sum();

      // to store and calculate the circle area in the floor plan

      Console.Write("How many circles are in the floor plan? ");
      string numberOfCirclesAsString = Console.ReadLine();
      numberOfCircles =  Convert.ToInt32(numberOfCirclesAsString);

      while (numberOfCircles > 0) {
        Console.Write("please enter the radius of the circle: ");
        double circleRadius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Is this a semi-circle? YES / NO: ");
        string answer = Console.ReadLine();
        answer.ToUpper();
        double circleArea;
        if (answer == "YES") {
          circleArea = Circles(circleRadius) / 2;
        } else {
          circleArea = Circles(circleRadius);
        }
        circleAreaArray = circleAreaArray.Concat(new double[] {circleArea}).ToArray();

        numberOfCircles--;
      }

      double totalCircleArea = circleAreaArray.Sum();

      // to store and calculate the triangle area on the floor plan

      Console.Write("How many triangles are in the floor plan? ");
      string numberOfTrianglesAsString = Console.ReadLine();
      numberOfTriangles =  Convert.ToInt32(numberOfTrianglesAsString);

      while (numberOfTriangles > 0) {
        Console.Write("Enter the bottom value of the triangle: ");
        string triangleBottom = Console.ReadLine();
        double triBottomAsDouble = Convert.ToDouble(triangleBottom);
        Console.Write("Enter the height value of the triangle: ");
        string triangleHeight = Console.ReadLine();
        double triHeightAsDouble = Convert.ToDouble(triangleHeight);
        double triangleArea = Triangles(triBottomAsDouble, triHeightAsDouble);
        triangleAreaArray = triangleAreaArray.Concat(new double[] {triangleArea}).ToArray();

        numberOfTriangles--;
      }

      double totalTriangleArea = triangleAreaArray.Sum();

      // total area is calculated below

      double floorPlanArea = totalRectangleArea + totalCircleArea + totalTriangleArea;
      Console.WriteLine($"The area of the complete floorplan is {floorPlanArea}m²");

      // The code below calculates the cost in gbp per square meter
      string stringPerSquareMeter;
      Console.Write("Please enter the price of flooring per square meter: ");
      stringPerSquareMeter = Console.ReadLine();
      int pricePerSquareMeter = Convert.ToInt32(stringPerSquareMeter);
      double floorPlanPrice = pricePerSquareMeter * floorPlanArea;
      Console.WriteLine($"The total price for the flooring will cost £{floorPlanPrice} to cover {floorPlanArea}m²");
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

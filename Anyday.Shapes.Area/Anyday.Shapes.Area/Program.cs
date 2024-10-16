
using Anyday.Shapes.Area;

var circle = new DerivedShapeCircle
{
    Radius = 10 //Get rid of this.
};
//I would like to initialize the radius from constructor.
var circleArea = circle.CalculateArea(circle.Radius);

Console.WriteLine("Area of circle is :" + circleArea.ToString());

var rectangle = new DerivedShapeRectangle
{
    Width = 10, //Get rid of these
    Height = 10
}; //I would like to initialize the radius from constructor.
var rectangleArea = rectangle.CalculateArea(rectangle.Width, rectangle.Width);

Console.WriteLine("Area of rectangle is:" + rectangleArea);

//Add more shape Rectangle and calculate it's Area.

//Add more shape Triangle and calculate it's Area.



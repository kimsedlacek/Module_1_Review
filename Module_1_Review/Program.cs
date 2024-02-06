//Circle
circleArea(5);
Console.WriteLine(circleArea(5));
static double circleArea(double radius)
{
    //var area = Math.PI * radius * radius;
    //Console.WriteLine(area);
    //return area;

    return Math.PI * radius * radius;    //either the commented way or this way work
}

//Triangle
triangleArea(8,15);
static double triangleArea(double baseLength, double height)
{
    var area = .5 * baseLength * height;  //triangle area calc by l*h/2
    return area;
}

//Rectangle
rectangleArea(5.3, 7.8);
static double rectangleArea(double length, double width)
{
    return length * width;
}

//Square
squareArea(5);
static double squareArea(double side)
{
    return side * side;   //square area calc side^2
}

Console.WriteLine();

//Circle - with User Input
Console.WriteLine("Give me a number to be the radius of a circle and I'll tell you its area.");
var radius = double.Parse(Console.ReadLine());
var carea = circleArea(radius);
Console.WriteLine($"The area of a circle with the radius of {radius} is {carea}.");

Console.WriteLine();

//Triangle - with User Input
Console.WriteLine("Think of any triangle shape. Now tell me what you think the length of the bottom and the height are.\n" +
    "Bottom Length?");
var baseLength = double.Parse(Console.ReadLine());
Console.WriteLine("and the Height?");
var height = double.Parse(Console.ReadLine());
var tarea = triangleArea(baseLength, height);
Console.WriteLine($"The area of a triangle with the bottom length of {baseLength} and the height of {height} is {tarea}.");

Console.WriteLine();

//Rectangle - with User Input
Console.WriteLine("Give me a length and width of a rectangle, and I'll give you it's area. First, what length do you want " +
    "to use?");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("and what width?");
double width = double.Parse(Console.ReadLine());
double rarea = rectangleArea(length, width);
Console.WriteLine($"The area of a rectangle with {length} length and {width} width is {rarea}");

Console.WriteLine();

//Square - with User Input
Console.WriteLine("Give me the length of one of the sides of a square and I'll give you its area.");
var side = double.Parse(Console.ReadLine());
var sarea = squareArea(side);
Console.WriteLine($"The area of a square whose sides are {side}, is {sarea}");
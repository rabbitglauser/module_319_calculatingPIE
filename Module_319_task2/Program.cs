//calculating the perimeter 
void CalculateCirclePerimeter(double radius)
{
    radius = 2 * Math.PI * radius;
    
    Console.WriteLine($"Radius = {radius}");
}

CalculateCirclePerimeter(5);

//calculating the circles Area 
void CalculateCircleArea(double _radius)
{
    _radius = Math.PI * double.Round(_radius,2);
    
    Console.WriteLine($"_Radius = {_radius}");
}

CalculateCirclePerimeter(9);
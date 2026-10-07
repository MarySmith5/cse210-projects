using System;

public class Square : Shape
{
    private double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return Math.Pow(_side, 2);
    }
}
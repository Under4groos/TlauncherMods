using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public struct Point
{
    public int X;
    public int Y;
     

    public Point(int x, int y) : this()
    {
        this.X = x;
        this.Y = y;
    }
    public Point(double x, double y) : this()
    {
        this.X = (int)x;
        this.Y = (int)y;
    }
    public override string ToString()
    {
        return $"x:{X} / y:{Y}";
    }
}

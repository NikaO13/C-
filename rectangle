using Avalonia.Controls;
using System;

namespace Rectangles;

public static class RectanglesTask
{
    public static bool AreIntersected(Rectangle r1, Rectangle r2)
    {
        var length = (r1.Right < r2.Left) || (r2.Right < r1.Left);
        var width = (r1.Bottom < r2.Top) || (r2.Bottom < r1.Top);
        return !(length || width);
    }


    public static int IntersectionSquare(Rectangle r1, Rectangle r2)
    {
        if (AreIntersected(r1, r2))
        {
            var length = (Math.Min(r1.Right, r2.Right) - Math.Max(r1.Left, r2.Left));
            var width = (Math.Min(r1.Bottom, r2.Bottom) - Math.Max(r1.Top, r2.Top));
            return length * width;
        }
        else
        {
            return 0;
        }
    }

    public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
    {
        var r1Width = ((r1.Top >= r2.Top) && (r1.Bottom <= r2.Bottom));
        var r1Height = ((r1.Left >= r2.Left) && (r1.Right <= r2.Right));
        var r2Width = ((r2.Top >= r1.Top) && (r2.Bottom <= r1.Bottom));
        var r2Height = ((r2.Left >= r1.Left) && (r2.Right <= r1.Right));
        if (r1Width && r1Height)
        {
            return 0;
        }
        else if (r2Width && r2Height)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}

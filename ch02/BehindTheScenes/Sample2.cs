﻿
public class Sample2
{
    public static void PassAnObject(object o)
    {
        if (o is IXY xy)
        {
            (int x, int y) = xy;
            // do something with x and y
        }
    }

    public static void PassAGeneric<T>(T t) where T : IXY
    {
        (int x, int y) = t;
        // do something with x and y
    }
}

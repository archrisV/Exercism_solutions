using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if( n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException("Inserted number is out of bounds.");
        }
        return (ulong) 1<<(n-1);
    }

    public static ulong Total() => ulong.MaxValue;
    
}
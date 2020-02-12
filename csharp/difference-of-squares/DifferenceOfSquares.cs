using System;
using System.Linq;
public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        return Convert.ToInt32(Math.Pow(Math.Floor(Convert.ToDouble(max * (max + 1)) / 2) , 2));
    }

    public static int CalculateSumOfSquares(int max)
    {
        return Convert.ToInt32(Enumerable.Range(1, max).Select(x => Math.Pow(x, 2)).Sum());
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        for (int sideA = 1; sideA <= sum / 3 - 1; sideA++)                                 
        { 
            for (int sideC = sum / 3 + 1; sideC < sum / 2; sideC++)     
            {
                int sideB = sum - sideA - sideC;
                if (Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) && sideA < sideB)
                {
                    yield return (sideA, sideB, sideC);
                }
            }
        }
    }
}
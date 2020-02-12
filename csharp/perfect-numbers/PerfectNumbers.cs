using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        int sum = 0;
        if (number < 1)
        { 
            throw new ArgumentOutOfRangeException("Argument out of range");
        }
        for( int i = 1; i < (number) ; i++)
        {
            if(number % i == 0)
            {
                sum += i;
            }
        }
        if (sum == number)
        {
            return Classification.Perfect;
        }
        return sum > number ? Classification.Abundant : Classification.Deficient;
    }
}

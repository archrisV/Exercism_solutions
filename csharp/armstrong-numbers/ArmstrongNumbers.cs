using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string num = number.ToString();
        double sum = 0;
        foreach (var x in num)
        {
            sum += Math.Pow(Convert.ToDouble(x.ToString()), num.Length);
        }
        return sum == number;
    }
}
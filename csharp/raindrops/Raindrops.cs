using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string result = number % 3 == 0 ? "Pling" : "";
        result += number % 5 == 0 ? "Plang" : "";
        result += number % 7 == 0 ? "Plong" : "";
        return result.Length > 0 ? result : number.ToString();
    }
}
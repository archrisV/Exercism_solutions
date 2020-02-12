using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        return input.Length != 0 ? input.Select(ch => ch.ToString())
                                        .Aggregate<string>((xs, x) => x + xs)
                                        : "";
    }
}
using System;
using System.Text.RegularExpressions;

public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        number = number.Replace("-", "");
        if(!IsLexicallyValid(number))
        {
            return false;
        }
        var sum = 0;
        var m = 10;
        int num;
        foreach (var x in number)
        {
            if(!Int32.TryParse(x.ToString(), out num))
            {
                num = 10;
            }
            sum += m * num;
            m--;
        }
        return sum % 11 == 0;
    }
    public static bool IsLexicallyValid(string num) => Regex.IsMatch(num, "^[0-9]{9}([0-9]|X)$");
}
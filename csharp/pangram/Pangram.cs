using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string dict = "abcdefghijklmnopqrstuvzwx";
        foreach(var x in dict)
        {
            if(!input.ToLower().Contains(x))
            {
                return false;
            }
        }
        return true;
    }
}

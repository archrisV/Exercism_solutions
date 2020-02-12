using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string alphabet = "abcedfghijklmnopqrstuvxywz";
        word = word.Replace(" ", "").Replace("-", "").Replace("_", "").ToLower();
        foreach (var letter in word)
        {
            if(!alphabet.Contains(letter))
            {
                return false;
            }
            alphabet = alphabet.Replace(letter.ToString(), "");
        }
        return true;
    }
}

using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder result = new StringBuilder();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string lowercaseText = text.ToLower();
        for (int i = 0; i < text.Length; i++)
        {
            if(alphabet.Contains(lowercaseText[i]))
            {
                var distance = (alphabet.IndexOf(lowercaseText[i]) + shiftKey) % alphabet.Length;
                var rotatedChar = Char.IsLower(text[i]) ? alphabet[distance] : Char.ToUpper(alphabet[distance]);
                result.Append(rotatedChar);
            }
            else
            {
                result.Append(text[i]);
            }   
        }
        return result.ToString();
    }


}
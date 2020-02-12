using System;
public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string acronym = "";
        string[] words = System.Text.RegularExpressions.Regex.Replace(phrase.Replace("_", "").Replace("-"," "), @"\s+", " ").Split(' ');
        foreach( var word in words )
        {   
            acronym += word.ToUpper()[0]; 
        }
        return acronym;
    }
}
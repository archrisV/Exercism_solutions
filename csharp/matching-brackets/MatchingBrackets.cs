using System;
using System.Collections.Generic;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>(){ 
                {'{', '}'}, 
                {'(', ')'}, 
                {'[', ']'} 
        };
        foreach(var character in input)
        {
            if(dict.ContainsKey(character))
            {
                stack.Push(character);
            }
            else if(dict.ContainsValue(character))
            {
                if (stack.Count == 0 || dict[stack.Pop()] != character)
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}

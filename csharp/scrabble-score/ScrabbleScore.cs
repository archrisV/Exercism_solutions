using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int sum = 0;
        foreach(var letter in input.ToLower()){
            if("aeioulnrst".Contains(letter)){
                sum += 1;
            }
            else if ("dg".Contains(letter))
            {
                sum += 2;
            }
            else if ("bcmp".Contains(letter))
            {
                sum += 3;
            }
            else if ("fhvwy".Contains(letter))
            {
                sum += 4;
            }
            else if ("k".Contains(letter))
            {
                sum += 5;
            }
            else if ("jx".Contains(letter))
            {
                sum += 8;
            }
            else if ("qz".Contains(letter))
            {
                sum += 10;
            }
        }
        return sum;
    }
}
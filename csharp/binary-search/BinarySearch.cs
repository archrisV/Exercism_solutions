using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int index;
        int left = 0;
        int right = input.Length - 1;
        while(left <= right)
        {
            index = (left + right) / 2;
            if(input[index] == value)
            {
                return index;
            }
            else if(input[index] > value)
            {
                right = index - 1;
            }
            else if(input[index] < value)
            {
                left = index + 1;
            }     
        }
        return -1;
    }
}
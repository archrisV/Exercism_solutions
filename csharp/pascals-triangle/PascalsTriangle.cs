using System;
using System.Collections.Generic;


public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<List<int>> xs = new List<List<int>>();
        int val = 1;
        for(int i = 0; i < rows; i++) 
        {
            List<int> tempList = new List<int>();
            for(int j = 0; j <= i; j++) 
            {
               if (j == 0 || i == 0)
               {
                  val = 1;
               }
               else
               {
                  val = val * ( i - j + 1 ) / j;
               }
               tempList.Add(val);
            }
            xs.Add(tempList);
         }
         return xs;
    }
}
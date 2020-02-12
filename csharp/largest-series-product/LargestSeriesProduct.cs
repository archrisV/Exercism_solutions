using System;
using System.Text.RegularExpressions;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if ( span > digits.Length || (digits.Length == 0 && span > 0) || 
            span < 0  || Regex.Match(digits, @"\D").Success)
        {
            throw new ArgumentException("Argument Error");
        } 
        else if (span == 0)
        {
            return 1;
        } 
        int largestProduct = 0; 
        int tempProduct = 0;
        for ( int i = 0; i <= digits.Length - span; i++)
        {
            Console.WriteLine(digits.Substring(i, span));
            tempProduct = digits.Substring(i, span)
                                .ToCharArray()
                                .Select(x => (int)char.GetNumericValue(x))
                                .Aggregate((x, y) => x * y);
            largestProduct = tempProduct > largestProduct ? tempProduct : largestProduct;
        }
        return largestProduct;
    }
}
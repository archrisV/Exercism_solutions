using System;
using System.Collections.Generic;
using System.Linq;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var result = new List<T>();
        foreach( var x in collection)
        {
            if(predicate(x))
            {
                result.Add(x);
            }
        }
        return result;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
         var result = new List<T>();
        foreach( var x in collection)
        {
            if(!predicate(x))
            {
                result.Add(x);
            }
        }
        return result;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public static class VariableLengthQuantity
{
    private const uint sevenBitsMask = 0x7fu;
    private const uint eightBitMask = 0x80u;
    public static uint[] Encode(uint[] numbers)
    {
        var bytes = new List<uint>();
        foreach(var number in numbers)
        {
            if( number == 0){
               bytes.Add(0u);
               continue;
            }
            var currentBytes = new List<uint>();
            var currentNumber = number;
            while (currentNumber > 0)
            {
                var tmp = currentNumber & sevenBitsMask;
                currentNumber >>= 7;
                if (currentBytes.Any())
                {
                    tmp |= eightBitMask;
                }
                currentBytes.Add(tmp);
            }   
            currentBytes.Reverse();
            bytes.AddRange(currentBytes);
        }
        return bytes.ToArray(); 
    }

    public static uint[] Decode(uint[] bytes)
    {
        var numbers = new List<uint>();
        var tmp = 0u;
        foreach(var tmpByte in bytes)
        {
            tmp = (tmp << 7) | (tmpByte & sevenBitsMask);
            if ((tmpByte & eightBitMask) == 0)
            {
                numbers.Add(tmp);
                tmp = 0;
            }
            else if (Array.IndexOf(bytes, tmpByte) == bytes.Length - 1)
            {
                throw new InvalidOperationException("Byte sequence is incomplete.");
            }
        }
        return numbers.ToArray();
    }
}
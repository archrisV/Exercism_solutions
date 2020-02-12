using System;
using System.Linq;
using System.Collections.Generic;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if(inputBase < 2 || outputBase < 2 || inputDigits.Any(x => x >= inputBase || x < 0))
        {
            throw new ArgumentException("Argument is out of bounds");       
        }
        return DecimalToBaseX(BaseXToDecimal(inputBase, inputDigits), outputBase);
        
    }
    private static int BaseXToDecimal(int inputBase, int[] inputDigits)
    {
        return inputDigits.Select((x, y) => x * (int)Math.Pow(inputBase, inputDigits.Length - 1 - y)).Sum();
    }

    private static int[] DecimalToBaseX(int number, int outputBase)
    {
        List<int> result = new List<int>();
        do
        {
            result.Add(number % outputBase);
            number /= outputBase;
        } while (number > 0);
        result.Reverse();
        return result.ToArray();
    }
}
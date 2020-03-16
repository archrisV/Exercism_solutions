using System;
using System.Collections.Generic;
using System.Linq;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        return !dominoes.Any() || IsChain(dominoes.First(), dominoes.Skip(1).ToList());
    }

    private static bool IsChain((int, int) currentDomino, List<(int, int)> dominoes)
    {
        if (!dominoes.Any())
        {
            return currentDomino.Item1 == currentDomino.Item2;
        }
        for (int i = 0; i < dominoes.Count; i++)
        {
            var nextDomino = dominoes[i];
            var remainingDominoes = dominoes.Where((d, index) => index != i).ToList();
            if(currentDomino.Item2 == nextDomino.Item1 && IsChain((currentDomino.Item1, nextDomino.Item2), remainingDominoes))
            {
                return true;
            }
            if(currentDomino.Item2 == nextDomino.Item2 && IsChain((currentDomino.Item1, nextDomino.Item1), remainingDominoes))
            {
                return true;
            }
        }
        return false;
    }
}
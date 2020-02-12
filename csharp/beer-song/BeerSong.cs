using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder song = new StringBuilder("");
        for(int i = 0, bottlesNo = startBottles; i < takeDown; i++, bottlesNo--)
        {
            if(bottlesNo < 1)
            {
                song.Append("No more bottles of beer on the wall, no more bottles of beer.\n" +
                        "Go to the store and buy some more, 99 bottles of beer on the wall.");
                break;
            }

            song.Append($"{bottlesNo} {(bottlesNo != 1 ? "bottles" : "bottle")} of beer on the wall, {bottlesNo} {(bottlesNo != 1 ? "bottles" : "bottle")} of beer.\n" +
            $"Take {(bottlesNo - 1 >= 1 ? "one" : "it")} down and pass it around, {(bottlesNo - 1 >= 1 ? (bottlesNo - 1).ToString() : "no more")} {(bottlesNo - 1 != 1 ? "bottles" : "bottle")} of beer on the wall." +
            ((i+1) < takeDown ? "\n\n" : ""));
        }
    
        return song.ToString();
    }
}
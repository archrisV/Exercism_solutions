using System;
using System.Collections.Generic;
public static class SecretHandshake
{

    public static string[] Commands(int commandValue)
    {
        List<string> commandList = new List<string>();
        Dictionary<int, string> commands = new Dictionary<int, string>()
                                        {
                                            {1, "wink"},
                                            {2, "double blink"},
                                            {4, "close your eyes"},
                                            {8, "jump"}
                                        }; 
        for(int i = 1; i < 9; i *= 2 )
        {
            if ((commandValue & i) == i)
            {
                commandList.Add(commands[i]);
            }
        }
        if((commandValue & 16) == 16)
        {
            commandList.Reverse();
        }
        return commandList.ToArray();
    }
}

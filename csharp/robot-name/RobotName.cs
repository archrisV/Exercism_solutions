using System;
using System.Collections.Generic;

public class Robot
{
    public static HashSet<string> uniqueNames = new HashSet<string>(10000);
    public string Name{ get; set; }
    public Robot() => Name = GenerateName();
    public void Reset() => Name = GenerateName();

    public string GenerateName()
    {
        Random r = new Random();
        string tempName = ((char) r.Next(65, 91)).ToString()
                + ((char) r.Next(65, 91)).ToString()
                + r.Next(0, 1000).ToString("D3");
        while(uniqueNames.Contains(tempName))
        {
            tempName = ((char) r.Next(65, 91)).ToString()
                + ((char) r.Next(65, 91)).ToString()
                + r.Next(0, 1000).ToString("D3");
        }
        uniqueNames.Add(tempName);
        return tempName;
    }
}
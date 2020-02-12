using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        phoneNumber = Regex.Replace(phoneNumber, @"\.?\s?\)?\(?\+?\-?","");
        phoneNumber = Regex.Replace(phoneNumber, @"^1", "");
        if(phoneNumber.Length != 10 || 
        Regex.Match(phoneNumber, @"\D").Success ||
        Regex.Match(phoneNumber, @"^(0|1)").Success ||
        Regex.Match(phoneNumber, @"^\d{3}(0|1)").Success
        )
        {
            throw new ArgumentException("Wrong input.");
        }
        return phoneNumber;
    }
}
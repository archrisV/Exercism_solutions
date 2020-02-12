using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    public int month;
    public int year;
    public Meetup(int month, int year)
    {
        this.month = month;
        this.year = year;
    }

    public DateTime FindDay(DayOfWeek dayOfWeek, DateTime dateObj, int iteration, int increment = 1)
    {
        int x = 0;
        while (dayOfWeek != dateObj.DayOfWeek || x != iteration)
                {
                   if(dayOfWeek == dateObj.DayOfWeek)
                   {
                       ++x;
                   }
                   dateObj = dateObj.AddDays(increment);
                }
        return dateObj;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        DateTime dateObj = new DateTime(year, month, 1);
        switch(schedule)
        {
            case Schedule.Teenth:
                dateObj = FindDay(dayOfWeek, new DateTime(year, month, 13), 0);
                break;
            case Schedule.First:
                dateObj = FindDay(dayOfWeek, dateObj, 0);
                break;
            case Schedule.Second:
                dateObj = FindDay(dayOfWeek, dateObj, 1);
                break;
            case Schedule.Third:
                dateObj = FindDay(dayOfWeek, dateObj, 2);
                break;
            case Schedule.Fourth:
                dateObj = FindDay(dayOfWeek, dateObj, 3);
                break;
            case Schedule.Last:
                dateObj = month != 12 ? 
                 new DateTime(year, month + 1, 1) :
                 new DateTime(year + 1, 1, 1);
                 dateObj = FindDay(dayOfWeek, dateObj.AddDays(-1), 0, -1);
                break;
            default:
                break;
        }
        return dateObj;
    }
}
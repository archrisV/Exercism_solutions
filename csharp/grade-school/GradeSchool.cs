using System;
using System.Collections.Generic;
public class GradeSchool
{
    public SortedDictionary<int, SortedSet<string>> studentRoster;
    public GradeSchool() => studentRoster = new SortedDictionary<int, SortedSet<string>>();
    public void Add(string student, int grade)
    {
        var tmpGrade = new SortedSet<string>();
        if(studentRoster.ContainsKey(grade))
        {
            tmpGrade = studentRoster[grade];
        }
        tmpGrade.Add(student);
        studentRoster[grade] = tmpGrade;
    } 
    public IEnumerable<string> Roster()
    {
        List<string> result = new List<string>();
        foreach(var grade in studentRoster.Keys)
        {
            foreach(var student in Grade(grade))
            {
                result.Add(student);
            }
        }
        return result.ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        if(studentRoster.ContainsKey(grade))
        {
            return studentRoster[grade];
        }
        return Array.Empty<string>();
    }  
}
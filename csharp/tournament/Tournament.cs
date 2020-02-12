using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public static class Tournament
{   
    public class Team
    {
        public Team(string name){
            Name = name;
            Wins = Draws = Loses = 0;
        }
        public string Name { get; }
        public int MatchesPlayed => Wins + Draws + Loses;
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int Points => Wins * 3 + Draws;

        public override string ToString() => $"{ Name, -31 }|{ MatchesPlayed, 3 } |{ Wins, 3 } |{ Draws, 3 } |{ Loses, 3 } |{ Points, 3 }";
    }
    public static void Tally(Stream inStream, Stream outStream)
    {
        List<Team> teams = ParseInput(GetInput(inStream));
        outStream.Write(Encoding.ASCII.GetBytes(GenerateTable(teams)));   
        outStream.Close();
    }

    // Method GetInput takes an input stream and returns the contents as a string
    public static string GetInput(Stream inStream)
    {
        var streamReader = new StreamReader(inStream);
        var input = streamReader.ReadToEnd();
        streamReader.Close();
        return input;
    }

    // Method ParseInput parses the input string and returns a list of teams and their statistics
    public static List<Team> ParseInput(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return new List<Team>();
        }
        var teams = new Dictionary<string, Team>();
        foreach(var line in input.Split('\n'))
        {
            var parsedLine = line.Split(";");
            if(!teams.ContainsKey(parsedLine[0]))
            {
                teams.Add(parsedLine[0], new Team(parsedLine[0]));
            }
            if(!teams.ContainsKey(parsedLine[1]))
            {
                teams.Add(parsedLine[1], new Team(parsedLine[1]));
            }
            switch(parsedLine[2])
            {
                case ("win"):
                    teams[parsedLine[0]].Wins++;
                    teams[parsedLine[1]].Loses++;
                    break;
                case("draw"):
                    teams[parsedLine[0]].Draws++;
                    teams[parsedLine[1]].Draws++;
                    break;
                case("loss"):
                    teams[parsedLine[0]].Loses++;
                    teams[parsedLine[1]].Wins++;
                    break;
                default:
                    throw new InvalidOperationException("Parse Error");
            }
        }
        return GetSortedTeams(teams);
    }

    public static String GenerateTable(List<Team> teams)
    {
        var tableString = new StringBuilder();
        tableString.Append("Team                           | MP |  W |  D |  L |  P");
        foreach(var team in teams)
        {
            tableString.Append("\n" + team.ToString());
        }
        return tableString.ToString();
    }
    public static List<Team> GetSortedTeams(Dictionary<string, Team> dict)
    {
        var teamList = new List<Team>();
        foreach(var team in dict.Values)
        {
            teamList.Add(team);
        }
        return teamList.OrderByDescending(x => x.Points).ThenBy(x => x.Name).ToList();
    }
}

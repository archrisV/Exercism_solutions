using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    private readonly string diagram;
    private readonly Dictionary<char, Plant> plantDict = new Dictionary<char, Plant>
                                { {'V', Plant.Violets}, {'R', Plant.Radishes}, {'C', Plant.Clover}, {'G', Plant.Grass}}; 
    public KindergartenGarden(string diagram) => this.diagram = diagram;
    public IEnumerable<Plant> Plants(string student) => ReplaceWithPlants(ParseDiagram()[ParseIndex(student)]);
    private List<string> ParseDiagram()
    {   
        var result = new List<string>();
        var tmp = diagram.Replace("\n", "");
        for(int i = 0; i < tmp.Length / 2; i+=2)
        {
            result.Add($"{tmp[i]}{tmp[i + 1]}{tmp[i + (tmp.Length / 2)]}{tmp[i + 1 + (tmp.Length / 2)]}");
        }
        return result;
    }
    private List<Plant> ReplaceWithPlants(string list) => list.Select(x => plantDict[x]).ToList();
    private int ParseIndex(string student) => student.Length > 1 ? Encoding.ASCII.GetBytes(student)[0] - 65 : 0;
    
}
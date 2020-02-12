using System;
using System.Linq;
using System.Collections.Generic;

public class Matrix
{
    public Matrix(string input)
    {
        Rows = ParseRows(input);
        Cols = ParseCols(input);
    }
    public List<List<int>> Rows{ get; set; }
    public List<List<int>> Cols{ get; set; }
    public int[] Row(int row) => Rows[row - 1].ToArray();
    public int[] Column(int col) => Cols[col - 1].ToArray();
    public List<List<int>> ParseRows(string input)
    {
        List<List<int>> rows = new List<List<int>>();
        foreach(var x in input.Split('\n'))
        {
            List<int> row = new List<int>();
            foreach(var y in x.Split(' '))
            {
                row.Add(Int32.Parse(y));
            }
            rows.Add(row);
        }
        return rows;
    }
    public List<List<int>> ParseCols(string input)
    {
        List<List<int>> cols = new List<List<int>>();
        for(int i = 0; i < Rows[0].ToArray().Length; i++)
        {
            List<int> col = new List<int>();
            for(int j = 0; j < Rows.ToArray().Length; j++)
            {
                col.Add(Rows[j][i]);
            }
            cols.Add(col);
        }
        return cols;
    }
}
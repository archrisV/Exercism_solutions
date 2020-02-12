using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class BinarySearchTree : IEnumerable<int>
{
    public int Value { get; set; }
    public BinarySearchTree Left { get; set; }
    public BinarySearchTree Right { get; set; }
    public BinarySearchTree(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
    public BinarySearchTree(IEnumerable<int> values) : this(values.First())
    {
        foreach (var value in values.Skip(1))
        {
            this.Add(value);
        }
    }
    public BinarySearchTree Add(int value)
    {
        if (value <= this.Value)
        {
            if (this.Left == null)
            {
                this.Left = new BinarySearchTree(value);
            }
            else
            {
                this.Left.Add(value);
            }         
        }
        else
        {
            if (this.Right == null)
            {
                this.Right = new BinarySearchTree(value);
            }             
            else
            {
                this.Right.Add(value);
            }               
        }
        return this;
    }
    public IEnumerator<int> GetEnumerator()
    {
        if (this.Left != null)
        {
            foreach (var value in this.Left)
            {
                yield return value;
            }
        }
        yield return this.Value;
        if (this.Right != null)
        {
            foreach (var value in this.Right)
            {
                yield return value;
            }
        }            
    }
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

}
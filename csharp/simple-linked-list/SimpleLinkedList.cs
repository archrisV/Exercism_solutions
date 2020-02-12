using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    private T value { get; set; }
    private SimpleLinkedList<T> next { get; set; }
    public SimpleLinkedList(T value)
    {
        this.value = value;
        this.next = null;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        this.value = values.First();
        this.next = null;
        foreach(var val in values.Skip(1))
        {
            this.Add(val);
        }
    }

    public T Value 
    { 
        get => this.value;
    }
    public SimpleLinkedList<T> Next
    { 
        get => this.next;
    }

    public SimpleLinkedList<T> Add(T value)
    {
        var current = this;
        while( current.next != null){
            current = current.next;
        }
        current.next = new SimpleLinkedList<T>(value);
        return this;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = this;
        do{
            yield return current.value;
            current = current.next;
        } while ( current != null);
    }

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();
}
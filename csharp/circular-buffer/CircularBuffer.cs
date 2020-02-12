using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private readonly int _capacity;

    private Queue<T> cBuffer { get; set; }
    public CircularBuffer(int capacity)
    {
        _capacity = capacity;
        cBuffer = new Queue<T>();
    }

    public T Read()
    {
        if( cBuffer.Count < 1)
        {
            throw new InvalidOperationException("Buffer is empty.");
        }
        return cBuffer.Dequeue();
    }

    public void Write(T value)
    {
        if( cBuffer.Count >= _capacity)
        {
            throw new InvalidOperationException("Buffer is full.");
        }
        cBuffer.Enqueue(value);
    }

    public void Overwrite(T value)
    {
        if(cBuffer.Count == _capacity)
        {
            cBuffer.Dequeue();
        }
        cBuffer.Enqueue(value);
    }

    public void Clear() => cBuffer.Clear();
}
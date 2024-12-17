using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Homework4;

public class TemplateCollection<T> : IEnumerable<T>
{
    private T[] _data;

    public event Action OnExpandedEvent;

    public TemplateCollection()
    {
        _data = [];

    }

    public T this[int index]
    {
        get => _data[index];
        set => _data[index] = value;
    }

    public void Add(T element)
    {
        Array.Resize(ref _data, _data.Length + 1);
        _data[^1] = element;
        OnExpandedEvent?.Invoke();
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var element in _data) yield return element;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        var collection = new TemplateCollection<int>();

        collection.OnExpandedEvent += () => Console.WriteLine("Array expansion");

        collection.Add(5);
        collection.Add(8);
        collection.Add(15);
        collection.Add(2);
        collection.Add(12);
        collection.Add(11);

        var sorted = collection.OrderBy(x => x).ToList();
        var filtered = collection.Where(x => x > 8).ToList();

        Console.WriteLine("Collection:");
        foreach (var element in collection) Console.WriteLine(element);

        Console.WriteLine("sSorted collection:");
        foreach (var element in sorted) Console.WriteLine(element);

        Console.WriteLine("Filtered collection:");
        foreach (var element in filtered) Console.WriteLine(element);
    }
}

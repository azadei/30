using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        List<string> elements = new List<string> { "Butter", "Honey", "Biscuit", "Brade", "Butter" };

        
        var arrangedList = elements.Distinct().OrderBy(element => element);

        
        Console.WriteLine("Here is the arranged list:");
        foreach (var element in arrangedList)
        {
            Console.WriteLine(element);
        }

    }
}
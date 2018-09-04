using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

myFamily.Add("father", new Dictionary<string, string>(){ 
    {"name", "Cole"},
    {"age", "42"}


});
myFamily.Add("mother", new Dictionary<string, string>(){ 
    {"name", "Amy"},
    {"age", "45"}


});
foreach (var item in myFamily)
{
    Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]} years old");
}
        }
    }
}

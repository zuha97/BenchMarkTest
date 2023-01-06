// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Immutable;
using System.Data;
using Bogus;
using System.Diagnostics;
using System.Threading.Tasks.Sources;


var randomAlphabeticalLetters = new Faker().Random.AlphaNumeric(1000).ToCharArray();

Console.WriteLine("Print 1000 Random letters");

var Stopwatch  = new Stopwatch();

//First Method
Stopwatch.Start();
Array.Sort(randomAlphabeticalLetters);

Stopwatch.Stop();
Console.WriteLine($"Time taken by array.sort method : {Stopwatch.ElapsedTicks} ticks");
Console.WriteLine($"Time taken by array.sort method : {Stopwatch.ElapsedMilliseconds} ms");


//Second Method
Stopwatch.Restart();
var result = from name in randomAlphabeticalLetters orderby name select name;
    
Stopwatch.Stop();
Console.WriteLine($"Time Taken By Query.next method : {Stopwatch.ElapsedTicks} ticks");
Console.WriteLine($"Time taken by Query method : {Stopwatch.ElapsedMilliseconds} ms");
/*foreach (var letters in result)
{
    Console.WriteLine(letters);
}*/



//Third Method
Stopwatch.Restart();
var result01 = new List<char>(randomAlphabeticalLetters);
result01.Sort();

Stopwatch.Stop();
Console.WriteLine($"Time Taken By LINQ Query Method : {Stopwatch.ElapsedTicks} ticks");
Console.WriteLine($"Time taken by LiNQ method : {Stopwatch.ElapsedMilliseconds} ms");

/*foreach (var word in result01)
{
    Console.WriteLine(word);
}*/
//Console.WriteLine($"Count of letters: {randomAlphabeticalLetters.Length}");

//Console.WriteLine(randomAlphabeticalLetters);
Console.ReadLine(); 


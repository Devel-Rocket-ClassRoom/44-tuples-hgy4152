using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.


var t1 = (1, 2);
var t2 = (1, 2);
var t3 = (1, 3);

Console.WriteLine(t1.Equals(t2));
Console.WriteLine(t1.Equals(t3));



Console.WriteLine(t1 == t2);
Console.WriteLine(t1 != t2);



var t5 = ("Alice", 25);
var t4 = t5;

Console.WriteLine($"{t4.Item1}, {t4.Item2}");



(string name, int age, char sex) t6 = ("Bob", 23, 'M');
(string age, int sex, char name) t7 = t6;

Console.WriteLine(t7.name);
Console.WriteLine(t7.age);
Console.WriteLine(t7.sex);


List<(string name, int age)> values = new List<(string name, int age)>();

var t8 = ("Alice", 25);
var t9 = ("Bob", 30);
var t10 = ("Charlie", 35);

values.Add(t8);
values.Add(t9);
values.Add(t10);

foreach(var value in values)
{
    Console.WriteLine($"{value.name}: {value.age}세");
}


Dictionary<(int x, int y), string> val = new()
{
    
    { (0, 0), "원점" },
    { (1, 0), "오른쪽" },
    { (0, 1), "위" }
};

Console.WriteLine(val[(0,0)]);
Console.WriteLine(val[(1,0)]);


var tuple = new Tuple<string, int>("Bob", 23);
var tuple1 = Tuple.Create("Alice", 25);

Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");
Console.WriteLine($"{tuple1.Item1}, {tuple1.Item2}");
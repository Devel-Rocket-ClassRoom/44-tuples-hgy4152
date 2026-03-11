using System;

// README.md를 읽고 코드를 작성하세요.


var tuple = ("Bob", 23);

Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);



var tuple2 = (12, 34, 56);

Console.WriteLine($"{tuple2.Item1}, {tuple2.Item2}, {tuple2.Item3}");


var tuple3 = ("Hello", 100, true, 3.14);

Console.WriteLine($"{tuple3.Item1}, {tuple2.Item2}, {tuple2.Item3}, {tuple3.Item4}");


(string, int) tuple5 = ("Alice", 25);

Console.WriteLine(tuple5);


(ushort Width, ushort Height) tuple6 = (1920, 1080);

Console.WriteLine($"해상도: {tuple6.Width} x {tuple6.Height}");

var tuple7 = tuple;

tuple7.Item1 = "Joe";

Console.WriteLine("원본: " + tuple);
Console.WriteLine("복사본: " +tuple7);




(string name, int age) tuple8 = tuple;

Console.WriteLine(tuple8.name);
Console.WriteLine(tuple8.age);
Console.WriteLine(tuple8.Item1);
Console.WriteLine(tuple8.Item2);


var tuple9 = (Name: "철수", IsStudent:  true, OrderPrice: 1000);
Console.WriteLine($"{tuple9.Name}(학생: {tuple9.IsStudent}) - 주문: {tuple9.OrderPrice:n0}원");


(string name, int age, char gender) tuple10 = ("Bob", 23, 'M');
Console.WriteLine($"이름: {tuple10.name}");
Console.WriteLine($"나이: {tuple10.age}");
Console.WriteLine($"성별: {tuple10.gender}");



var tuple11 = DateTime.Now;
var tuple12 = (tuple11.Day, tuple11.Month, tuple11.Year);

Console.WriteLine($"일: {tuple11.Day}");
Console.WriteLine($"월: {tuple11.Month}");
Console.WriteLine($"년: {tuple11.Year}");
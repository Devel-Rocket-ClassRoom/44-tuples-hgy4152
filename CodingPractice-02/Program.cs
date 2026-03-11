using System;

// README.md를 읽고 코드를 작성하세요.


var tup1 = Tally(12, 3);
Console.WriteLine($"합계: {tup1.Item1}, 개수: {tup1.Item2}");
(int, int) Tally(int sum, int total) => (sum, total);




// 이미 선언된 곳에 할당할땐 이름 지정 불가능함
// 별칭은 생성 때만
var tup2 = Calculate(45, 6);
Console.WriteLine($"합계: {tup2.sum}, 개수: {tup2.count}");

(int sum, int count) Calculate(int sum, int total) => (sum, total);



var tup3 = GetPair(100, 200);
Console.WriteLine($"{tup3.first}, {tup3.second}");
(int first, int second) GetPair(int a, int b) => (a, b);


int[] ints = { 5, 2, 8, 1, 9, 3 };

var tup4 = FindMinMax(ints);
Console.WriteLine($"최솟값: {tup4.min}, 최댓값: {tup4.max}");

(int min, int max) FindMinMax(int[] nums)
{
    int min = int.MaxValue;
    int max = int.MinValue;

    foreach (int num in nums)
    {
        if (num < min) min = num;
        if (num > max) max = num;
    }


    return (min, max);
}

var tup5 = ZeroZero();
Console.WriteLine($"{tup5.Item1}, {tup5.Item2}");

(int, int) ZeroZero() => default;


var tup6 = ("Bob", 23);

(string name, int age) = tup6;

Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");


var (sum, count) = Tally(12, 3);

Console.WriteLine($"Sum: {sum}, Count: {count}");

var tup7 = ("Alice", 30);

(name, age) = tup7;

Console.WriteLine($"{name}, {age}");

var tup8 = ("gadsdf", 23, true);

(_,age,_) = tup8;

Console.WriteLine($"나이: {age}");
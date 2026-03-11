using System;

// README.md를 읽고 코드를 작성하세요.




var student1 = CreateStudent("철수", 16, 1);
var student2 = CreateStudent("영희", 17, 2);
var student3 = CreateStudent("민수", 18, 3);

Console.WriteLine("=== 학생 정보 출력 ===");
PrintStudent(student1);
PrintStudent(student2);
PrintStudent(student3);


Console.WriteLine("=== 첫 번째 학생 분해 ===");
(string name, int age, int grade) = student1;
Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");
Console.WriteLine($"학년: {grade}");

(string name, int age, int grade) CreateStudent(string name, int age, int grade)
{ 
    return (name, age, grade);
}


void PrintStudent((string name, int age, int grade) info)
{
    Console.WriteLine($"{info.name} - 나이: {info.age}세, 학년: {info.grade}학년");
}
using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.


List<(string name, int quantity, int price)> inventory = new List<(string name, int quantity, int price)>();




Console.WriteLine("=== 아이템 인벤토리 ===");
AddItem(inventory, "체력 포션", 3, 500);
AddItem(inventory, "마나 포션", 5, 800);
AddItem(inventory, "해독제", 2, 300);
AddItem(inventory, "엘릭서", 1, 5000);

PrintInfo(inventory);

Console.WriteLine("===가장 비싼 아이템 ===");
var expensiveItem = FindMostExpensive();
Console.WriteLine($"이름: {expensiveItem.name}, 단가: {expensiveItem.price:n0}원");


Console.WriteLine("=== 인벤토리 합산 ===");
var total = CalculateTotal();

Console.WriteLine($"총 가치: {total.totalValue:n0}원");
Console.WriteLine($"총 아이템 수: {total.totalCount:n0}개");


void PrintInfo(List<(string name, int quantity, int price)> inventory)
{
    foreach(var item in inventory)
    {
        Console.WriteLine($"{item.name} - 수랑: {item.quantity}개, 단가: {item.price:0}원");
    }    
}


void AddItem(List<(string name, int quantity, int price)> inventory, string name, int quantity, int price)
{
    var t = (name, quantity, price); 
    inventory.Add(t);
}


(string name, int price) FindMostExpensive()
{
    int max = int.MinValue;
    string name = null;
    foreach (var t in inventory)
    {
        if (t.price > max) max = t.price; name = t.name;
    }



    return  (name, max);
}

(int totalValue, int totalCount) CalculateTotal()
{
    int sumPrice = 0;
    int sumQuantity = 0;
    

    foreach(var t in inventory)
    {
        sumPrice += t.price * t.quantity;
        sumQuantity += t.quantity;
    }

    return (sumPrice, sumQuantity);
}
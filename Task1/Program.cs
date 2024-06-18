using Class_Order;
using Task2;

Order order = new();
order.Print();
Console.WriteLine("______________________________");

Console.WriteLine("Operators:"); //вывод операторов

Order order1 = new() { _Summ = 0 };
Console.WriteLine(order1._Summ);
order1++;
order1.Print();

Console.WriteLine("______________________________"); //вывод класса
Order order2 = new() { _Summ = 2000, _Address = "ул. Пушкина д. Колотушкино", _Name = "Илья" };
Order order3 = new() { _Summ = 500 };
Console.WriteLine(order2._Summ);
Console.WriteLine(order3._Summ);

Console.WriteLine("______________________________");
Console.WriteLine(Order.Equals);

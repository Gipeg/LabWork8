using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Order
{
    internal class Order
    {
        public string _Name { get; set; }
        public string _Address { get; set; }
        public int _Summ { get; set; }

        public Order() //первоначальный класс
           : this("Неизвестна", "Неизвестен", 0) { }

        public Order(string Name, string Address, int Summ) //присваивание переменным служебные имена
        {
            _Name = Name;
            _Address = Address;
            _Summ = Summ;
        }


        public static Order operator ++(Order order) => new Order //второй элемент класса не 0 а 1
        {
            _Name = order._Name,
            _Address = order._Address,
            _Summ = order._Summ + 1
        };

        #region Overload
        public override string ToString()
        {
            return $"Name: {_Name}, Address: {_Address}, Summ: {_Summ} ";
        }
        public override bool Equals(object? obj)
        {
            Order order = obj as Order;
            return _Name == order._Name && _Address == order._Address && _Summ == _Summ;
        }
        #endregion

        public static Order operator +(Order a, Order b) => new Order //присваивание из Program.CS имён в класс
        {
            _Name = a._Name,
            _Address = a._Address,
            _Summ = a._Summ + b._Summ
        };


        //рассчёты операторов
        public static bool operator &(Order a, Order b) => a._Summ == b._Summ;

        public static bool operator ^(Order a, Order b) => a._Summ != b._Summ;

        public static bool operator true(Order order) => order._Summ >= 0;

        public static bool operator false(Order order) => order._Summ < 0;

        public void Print() //вывод класса
        {
            Console.WriteLine($"Заказ: {_Name}, адрес: {_Address}, Сумма: {_Summ}");
        }
    }
}

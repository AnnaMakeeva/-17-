using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17_на_отправку
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер счета");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Bank<int> bank1 = new Bank<int>(number, balance, name);
            bank1.Print();
            Console.ReadKey();
            Console.WriteLine("Введите номер счета");
            string number1 = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            double balance1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите имя");
            string name1 = Console.ReadLine();
            Bank<string> bank2 = new Bank<string>(number1, balance1, name1);
            bank2.Print();
            Console.ReadKey();
        }
    }
    class Bank<T>
    {
        public T number { get; set; }
        public double balance { get; set; }
        public string name { get; set; }
        public Bank(T number, double balance, string name)
        {
            this.number = number;
            this.balance = balance;
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine("\nномер счета:{0}\nбаланс:{1:f2}\nимя:{2}\n", number, balance, name);
        }
    }

}

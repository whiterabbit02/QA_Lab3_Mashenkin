using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testirovanie3
{
    ///<summary>
    ///<brief>Базовый класс "Число"</brief>
    /// Данный класс нужен для хранения и обработки информации о числе
    ///</summary>
    public class Number
    {
        protected int dig1;
        protected int dig2;
        protected int dig3;
        public void Init(int d1, int d2, int d3) { dig1 = d1; dig2 = d2; dig3 = d3; }
        ///<summary>
        ///Вывод числа в консоль
        ///</summary>
        public void Display()
        {
            Console.Write(dig1);
            Console.Write(dig2);
            Console.Write(dig3);
        }
        ///<summary>
        ///Получение первой цифры числа
        ///</summary>
        public int getDig1()
        {
            return dig1;
        }
        ///<summary>
        ///Получение второй цифры числа
        ///</summary>
        public int getDig2()
        {
            return dig2;
        }
        ///<summary>
        ///Получение третьей цифры числа 
        ///</summary>
        public int getDig3()
        {
            return dig3;
        }
        ///<summary>
        ///Ввод цифр
        ///</summary>
        public void Read()
        {
            Console.Write("Введите первую цифру: ");
            dig1 = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую цифру: ");
            dig2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третью цифру: ");
            dig3 = int.Parse(Console.ReadLine());
        }
        ///<summary>
        ///Сложение числа из отдельных цифр
        ///</summary>
        public int Num()
        {
            int a, b, c;
            int n;
            a = dig1 * 100;
            b = dig2 * 10;
            c = b + dig3;
            n = a + c;
            return n;
        }
        ///<summary>
        ///Добавление числа
        ///</summary>
        public Number Add(Number a, Number b)
        {
            Number s;
            s = new Number();
            int k, l;
            s.dig1 = a.dig1 + b.dig1;
            k = a.dig2 + b.dig2;
            if (k >= 10)
            {
                s.dig1++;
                k = k - 10;
            }
            s.dig3 = a.dig3 + b.dig3;
            l = a.dig3 + b.dig3;
            s.dig2 = k;
            s.dig3 = l;
            return s;
        }
        /// <summary>
        /// <brief>Конструктор класса "Число"</brief>
        /// </summary>
        public Number(int d1, int d2, int d3)
        {
            dig1 = d1;
            dig2 = d2;
            dig3 = d3;
        }
        /// <summary>
        ///Определение нуля при пустом вводе входящих данных
        /// </summary>
        public Number()
        {
            dig1 = 0;
            dig2 = 0;
            dig3 = 0;
        }
    }


    /// <summary>
    /// <brief>Производный класс "Знак"</brief>
    /// Дочерний класс, наследованный от ранее созданного класса Number
    /// </summary>
    internal class Sign : Number
    {
        private int si;
        ///<summary>
        ///Инициализация
        ///</summary>
        public void Init(int d1, int d2, int d3, int s)
        {
            base.Init(d1, d2, d3);
            si = s;
        }

        ///<summary>
        ///Вывод числа в консоль
        ///</summary>
        public void Display()
        {
            Console.Write(dig1);
            Console.Write(dig2);
            Console.Write(dig3);
            Console.WriteLine("\nЦифра, определяющая знак: " + si);
        }

        /// <summary>
        ///Получение числа, определяющего знак  
        /// </summary>
        public int Get()
        {
            return si;
        }
        /// <summary>
        ///Определение числа, определяющего знак  
        /// </summary>
        public void Put(int s)
        {
            si = s;
        }

        /// <summary>
        ///Сборка числа в зависимости от знака 
        /// </summary>
        public int Num()
        {
            int a, b, c;
            int n = 0;
            if (si == 1)
            {
                a = dig1 * 100;
                b = dig2 * 10;
                c = b + dig3;
                n = a + c;
            }
            if (si == -1)
            {
                a = -1 * dig1 * 100;
                b = -1 * dig2 * 10;
                c = b + dig3 * -1;
                n = a + c;
            }
            if (si == 0)
            {
                a = 0 * dig1 * 100;
                b = 0 * dig2 * 10;
                c = b + dig3 * 0;
                n = a + c;
            }
            return n;
        }
        /// <summary>
        /// <brief>Конструктор класса "Знак"</brief>
        /// </summary>
        public Sign(int d1, int d2, int d3, int s) : base(d1, d2, d3)
        {
            si = s;
        }

        /// <summary>
        /// <brief>Базовый объект класса "Знак"</brief>
        /// </summary>
        public Sign() : base()
        {
            si = 0;
        }
    }

    /// <summary>
    /// <brief>Класс "Program"</brief>
    /// Данный класс нужен для исполнения кода
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            Sign s = new Sign();
            n.Init(1, 1, 1);
            s.Init(1, 1, 1, -1);
            Console.WriteLine(s.Num());

            Sign sig = new Sign(5, 5, 5, 1);
            Console.WriteLine("Инициализация переменной через конструктор с параметрами:");
            sig.Display();
            Console.ReadKey();
        }
    }
}

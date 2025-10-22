using System;

namespace Methods
{
    class Program
    {
        // Задачи 1,2,7,9,12,13,14,19 - Сложение двух чисел
        static int AddTwo(int a, int b) => a + b;

        // Задачи 3 - Максимум из трех чисел
        static int MaxOfThree(int a, int b, int c) => Math.Max(a, Math.Max(b, c));

        // Задачи 4,5,6,15,16 - Четное число (предикат)
        static bool IsEven(int n) => n % 2 == 0;

        // Задачи 8,10,17,18,20 - Вывод диапазона
        static void PrintRange(int a, int b)
        {
            for (int i = a; i <= b; i++) Console.WriteLine(i);
        }

        // Задача 11 - Факториал
        static int Factorial(int n)
        {
            if (n < 0) return 0;
            int result = 1;
            for (int i = 1; i <= n; i++) result *= i;
            return result;
        }

        // Задачи 21,24,29,33,34 - Квадрат числа
        static int Square(int x) => x * x;

        // Задачи 22,26,42 - Палиндром
        static bool IsPalindrome(string s)
        {
            s = s.ToLower().Replace(" ", "");
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return s == new string(arr);
        }

        // Задачи 23,25,30,38,45 - Изменение через ref
        static void Increment(ref int x) => x++;

        // Задачи 28,36,37,39,44 - Hello World процедура
        static void HelloWorld() => Console.WriteLine("Hello, World!");

        // Задачи 27,31,32,35,40,41,43 - Демонстрация разницы
        static void DemoProcedure(int x) { Console.WriteLine($"Процедура: {x}"); }
        static int DemoFunction(int x) => x * 2;

        // Задачи 46,50,52,54,73,75 - Минимум в массиве
        static int MinArray(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int min = arr[0];
            foreach (int x in arr) if (x < min) min = x;
            return min;
        }

        // Задачи 47,49,56,57,60,62,72 - Среднее массива
        static double AverageArray(int[] arr)
        {
            if (arr.Length == 0) return 0;
            return arr.Sum() / (double)arr.Length;
        }

        // Задачи 48,63,65,173,179,184,186,188 - Копирование массива
        static int[] CopyArray(int[] arr) => (int[])arr.Clone();

        // Задачи 51,53,59,64,66,68,69,71 - Длина строки
        static int StringLength(string s) => s.Length;

        // Задачи 55,58,61,67,70,74 - Сложение ТРЕХ чисел (переименован)
        static int AddThree(int a, int b, int c) => a + b + c;

        // Задачи 76,77,82,85,91,94,98,100,101 - Код ошибки
        static int ValidateInput(int x)
        {
            if (x < 0) return -1;
            return x;
        }

        // Задачи 78,79,88,95,96,97 - Делимость на 3
        static bool DivisibleByThree(int x) => x % 3 == 0;

        // Задачи 80,83,87,89,93,99,104 - Ранний return
        static string EarlyReturn(string? s)
        {
            if (string.IsNullOrEmpty(s)) return "Пустая строка";
            return $"Обработано: {s}";
        }

        // Задачи 81,92,102,103,105 - Null для пустой строки
        static string? NullIfEmpty(string? s) => string.IsNullOrEmpty(s) ? null : s;

        // Задачи 84,86,90 - Множественные return
        static string MultipleReturn(int x)
        {
            if (x < 0) return "Отрицательное";
            if (x == 0) return "Ноль";
            return "Положительное";
        }

        // Задачи 106,108,113,119,122,123,125,136,138 - Деление на ноль
        static double SafeDivide(double a, double b)
        {
            if (b == 0) return 0;
            return a / b;
        }

        // Задачи 107,112,120,124,126,128,131 - Guard в конструкторе
        static bool ValidateRequired(string? param)
        {
            if (string.IsNullOrEmpty(param)) return false;
            return true;
        }

        // Задачи 109,127,132,133,135,140 - Диапазон
        static bool InRange(int x, int min, int max)
        {
            if (x < min || x > max) return false;
            return true;
        }

        // Задачи 110,111,117,118,137 - Пустой массив (void)
        static void ProcessArray(int[] arr)
        {
            if (arr.Length == 0) return;
            Console.WriteLine($"Размер: {arr.Length}");
        }

        // Задачи 114,115,116,121,129,130,134,139 - Null аргумент
        static void ValidateNotNull(string? s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));
            Console.WriteLine(s);
        }

        // Задачи 141,143,146,147,152,153,155,165,170 - Отрицательная сумма
        static string ValidateSum(double sum)
        {
            if (sum < 0) return "Ошибка: отрицательная сумма";
            return $"OK: {sum}";
        }

        // Задачи 142,148,149,151,162,164 - Возраст
        static bool ValidateAge(int age)
        {
            if (age < 18) return false;
            return true;
        }

        // Задачи 144,154,158,159,163,166,167,169 - Короткий пароль
        static void ValidatePassword(string password)
        {
            if (password.Length < 8) throw new ArgumentException("Пароль слишком короткий");
            Console.WriteLine("Пароль OK");
        }

        // Задачи 145,150,156,160,161 - Уникальность email
        static bool IsEmailUnique(string email)
        {
            if (email.Contains("test")) return false;
            return true;
        }

        // Задача 157,168 - Неверная дата
        static void ValidateDate(string date)
        {
            if (!DateTime.TryParse(date, out _)) throw new FormatException("Неверный формат даты");
            Console.WriteLine("Дата OK");
        }

        // Задачи 171,172,175,180,182,190,191,197,199 - Деление (частное + остаток)
        static int Divide(int a, int b, out int remainder)
        {
            remainder = a % b;
            return a / b;
        }

        // Задачи 173,179,184,186,188 - Заполнение массива
        static void FillArray(out int[] arr)
        {
            arr = new int[5];
            for (int i = 0; i < 5; i++) arr[i] = i * 2;
        }

        // Задачи 174,177,178,181,187,195,196,198 - bool + out результат
        static bool TryParseNumber(string s, out int result)
        {
            result = 0;
            return int.TryParse(s, out result);
        }

        // Задачи 176,183,185,193 - Увеличение через ref
        static void Increase(ref int x) => x += 10;

        // Задачи 189,192,194,200 - Swap через ref
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // дЕМОНСТРАЦИЯ
        static void Main()
        {

            // Обзор методов (20 задач)
            Console.WriteLine("\n1-20. Обзор методов:");
            Console.WriteLine($"1-2,7,9,12-14,19: {AddTwo(5, 3)}");
            Console.WriteLine($"3: {MaxOfThree(1, 3, 2)}");
            Console.WriteLine($"4-6,15-16: {IsEven(4)}");
            PrintRange(1, 3);
            Console.WriteLine($"11: {Factorial(5)}");

            // Процедуры vs Функции (25 задач)
            Console.WriteLine("\n21-45. Процедуры vs Функции:");
            Console.WriteLine($"21,24,29,33,34: {Square(5)}");
            Console.WriteLine($"22,26,42: {IsPalindrome("radar")}");
            int x = 10; Increment(ref x); Console.WriteLine($"23,25,30,38,45: {x}");
            HelloWorld();
            DemoProcedure(5);
            Console.WriteLine($"27,31-35,40-43: {DemoFunction(5)}");

            // Массивы и строки (27 задач)
            Console.WriteLine("\n46-74. Массивы и строки:");
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine($"46,50,52,54,73,75: {MinArray(arr)}");
            Console.WriteLine($"47,49,56,57,60,62,72: {AverageArray(arr):F2}");
            Console.WriteLine($"48,63,65: {CopyArray(arr).Length}");
            Console.WriteLine($"51,53,59,64,66,68,69,71: {StringLength("Hello")}");
            Console.WriteLine($"55,58,61,67,70,74: {AddThree(1, 2, 3)}");

            // return (30 задач)
            Console.WriteLine("\n76-105. Управляющая return:");
            Console.WriteLine($"76,77,82,85,91,94,98,100,101: {ValidateInput(-1)}");
            Console.WriteLine($"78,79,88,95-97: {DivisibleByThree(9)}");
            Console.WriteLine($"80,83,87,89,93,99,104: {EarlyReturn("test")}");
            Console.WriteLine($"81,92,102,103,105: {NullIfEmpty("") == null}");
            Console.WriteLine($"84,86,90: {MultipleReturn(5)}");

            // Guard Clauses (35 задач)
            Console.WriteLine("\n106-140. Guard Clauses:");
            Console.WriteLine($"106,108,113,119,122,123,125,136,138: {SafeDivide(10, 0)}");
            Console.WriteLine($"107,112,120,124,126,128,131: {ValidateRequired("test")}");
            Console.WriteLine($"109,127,132,133,135,140: {InRange(5, 1, 10)}"); 
            ProcessArray(new int[0]);
            try { ValidateNotNull(null); } catch { Console.WriteLine("114-116,121,129,130,134,139: Исключение"); }

            //Защита номинального (30 задач)
            Console.WriteLine("\n141-170. Защита номинального:");
            Console.WriteLine($"141,143,146,147,152,153,155,165,170: {ValidateSum(-5)}");
            Console.WriteLine($"142,148,149,151,162,164: {ValidateAge(20)}");
            try { ValidatePassword("123"); } catch { Console.WriteLine("144,154,158,159,163,166,167,169: Исключение"); }
            Console.WriteLine($"145,150,156,160,161: {IsEmailUnique("user@mail.com")}");
            try { ValidateDate("invalid"); } catch { Console.WriteLine("157,168: Исключение"); }

            //ref/out (30 задач)
            Console.WriteLine("\n171-200. ref/out:");
            int rem; Console.WriteLine($"171,172,175,180,182,190,191,197,199: {Divide(10, 3, out rem)}, остаток: {rem}");
            FillArray(out int[] filled); Console.WriteLine($"173,179,184,186,188: {filled[0]}");
            string num = "123"; Console.WriteLine($"174,177,178,181,187,195,196,198: {TryParseNumber(num, out int res)}, {res}"); 
            int val = 5; Increase(ref val); Console.WriteLine($"176,183,185,193: {val}");
            int a = 1, b = 2; Swap(ref a, ref b); Console.WriteLine($"189,192,194,200: {a},{b}"); 

            Console.ReadKey();
        }
    }
}
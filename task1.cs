using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class task1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1");
        Console.WriteLine("Введите значение переменной - t");
        double t = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - y");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"R = {Math.Pow(t, 2) + Math.Pow(y, 3) + 4.9}");
        Console.ReadKey();

        Console.WriteLine("Задание 2");
        Console.WriteLine("Введите значение переменной - p");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"K = {Math.Log(Math.Pow(p, 2) + Math.Pow(y, 3)) + Math.Exp(p)}");
        Console.ReadKey();

        Console.WriteLine("Задание 3");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"G = {Math.PI * (y + 3.5) + Math.Sqrt(y)}");
        Console.ReadKey();

        Console.WriteLine("Задание 4");
        Console.WriteLine("Введите значение переменной - a");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - r");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"D = {9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(r, 5))}");
        Console.ReadKey();

        Console.WriteLine("Задание 5");
        Console.WriteLine("Введите значение переменной - x");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"L = {1.51 * Math.Cos(Math.Pow(x, 2)) + 2 * Math.Pow(x, 3)}");
        Console.ReadKey();

        Console.WriteLine("Задание 6");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"M = {Math.Cos(2 * y) + 3.6 * Math.Exp(y)}");
        Console.ReadKey();

        Console.WriteLine("Задание 7");
        Console.WriteLine("Введите значение переменной - m");
        double m = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"N = {Math.Pow(m, 2) + 2.8 * Math.PI + 0.55}");
        Console.ReadKey();

        Console.WriteLine("Задание 8");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"T = {Math.Sqrt(Math.Pow(y, 2) - 0.1 * y + 4)}");
        Console.ReadKey();

        Console.WriteLine("Задание 9");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - x");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"V = {Math.Log(y + 0.95) + Math.Sin(Math.Pow(x, 4))}");
        Console.ReadKey();

        Console.WriteLine("Задание 10");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - x");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"U = {Math.Exp(y) + 7.355 * Math.Pow(x, 2) + Math.Sin(Math.Pow(x, 2))}");
        Console.ReadKey();

        Console.WriteLine("Задание 11");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - x");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"S = {9.756 * Math.Pow(y, 7) + 2 * Math.Tan(x)}");
        Console.ReadKey();

        Console.WriteLine("Задание 12");
        Console.WriteLine("Введите значение переменной - t");
        t = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - x");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"K = {7 * Math.PI * Math.Pow(t, 2) + 3 * Math.Sin(x) + 9.2}");
        Console.ReadKey();

        Console.WriteLine("Задание 13");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"E = {Math.Sqrt(Math.Pow(3 * y, 2) + 0.5 * y + 4)}");
        Console.ReadKey();

        Console.WriteLine("Задание 14");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"R = {Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835 * Math.Exp(y))}");
        Console.ReadKey();

        Console.WriteLine("Задание 15");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"H = {Math.Sin(Math.Pow(y, 2)) - 2.8 * Math.Pow(y, 2) + Math.Sqrt(y)}");
        Console.ReadKey();

        Console.WriteLine("Задание 16");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"S = {Math.Sqrt(Math.Cos(4 * y) * Math.Pow(y, 2) + 7.151)}");
        Console.ReadKey();

        Console.WriteLine("Задание 17");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"N = {3 * Math.Pow(y, 2) + Math.Sqrt(y + 1)}");
        Console.ReadKey();

        Console.WriteLine("Задание 18");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Z = {3 * Math.Pow(y, 2) + Math.Sqrt(Math.Pow(y, 3) + 1)}");
        Console.ReadKey();

        Console.WriteLine("Задание 19");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"F = {Math.PI * Math.Sqrt(Math.Pow(y, 3)) + 1.09 * 9.81}");
        Console.ReadKey();

        Console.WriteLine("Задание 20");
        Console.WriteLine("Введите значение переменной - t");
        t = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"U = {Math.Exp(-t * y) + Math.Tan(Math.Sqrt(y))}");
        Console.ReadKey();

        Console.WriteLine("Задание 21");
        Console.WriteLine("Введите значение переменной - v");
        double v = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - h");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"P = {Math.Pow(v + 5.5, 9.1 * h)}");
        Console.ReadKey();

        Console.WriteLine("Задание 22");
        Console.WriteLine("Введите значение переменной - u");
        double u = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"T = {Math.Sin(2 * u) * Math.Log(2 * Math.Pow(y, 2) + Math.Sqrt(y))}");
        Console.ReadKey();

        Console.WriteLine("Задание 23");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - f");
        double f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"G = {Math.Exp(2 * y) + Math.Sin(f)}");
        Console.ReadKey();

        Console.WriteLine("Задание 24");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"F = {2 * Math.Sin(0.214 * Math.Pow(y, 5) + 1)}");
        Console.ReadKey();

        Console.WriteLine("Задание 25");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - f");
        f = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"G = {Math.Exp(2 * y) + Math.Sin(Math.Pow(f, 2))}");
        Console.ReadKey();

        Console.WriteLine("Задание 26");
        Console.WriteLine("Введите значение переменной - p");
        p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Z = {Math.Sin(Math.Pow(p, 2) + 0.4)}");
        Console.ReadKey();

        Console.WriteLine("Задание 27");
        Console.WriteLine("Введите значение переменной - v");
        v = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - x");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"W = {1.03 * v + Math.Exp(2 * y) + Math.Tan(Math.Pow(x, 2))}");
        Console.ReadKey();

        Console.WriteLine("Задание 28");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - h");
        h = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"T = {Math.Exp(2 * y * h) + Math.Sqrt(6.4 * y)}");
        Console.ReadKey();

        Console.WriteLine("Задание 29");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"N = {3 * Math.Pow(v, 2) + Math.Sqrt(y + 1)}");
        Console.ReadKey();

        Console.WriteLine("Задание 30");
        Console.WriteLine("Введите значение переменной - y");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной - r");
        r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"W = {Math.Exp(2 * y * r) + 7.2 * Math.Sin(r)}");
        Console.ReadKey();
    }
}